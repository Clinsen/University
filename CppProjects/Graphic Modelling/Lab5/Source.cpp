#include <GL/glut.h>

void drawGammaSymbol()
{
    float controlPoints[][3] = {
    { -0.5f, 0.4f, -0.3f },   // Top-left
    { -0.7f, 0.3f, 0.0f },   // Bottom-left
    { -0.5f, 0.0f, 0.0f },   // Bottom-left curve control point
    { -0.2f, 0.0f, 0.0f },   // Bottom-right curve control point
    { -0.2f, 0.2f, 0.0f },   // Top-right curve control point
    { -0.1f, 0.4f, 0.0f },   // Top-right curve control point
    { -0.4f, 0.4f, 0.0f },   // Top-right curve control point
    { -0.4f, 0.2f, 0.0f },   // Bottom-right curve control point
    { -0.4f, 0.0f, 0.0f },   // Bottom-right curve control point
    { -0.3f, 1.0f, 0.0f }    // Bottom-right
    };


    glMap1f(GL_MAP1_VERTEX_3, 0.0, 1.0, 3, 9, &controlPoints[0][0]);

    glEnable(GL_MAP1_VERTEX_3);

    glBegin(GL_LINE_STRIP);
    for (int i = 0; i <= 100; i++) {
        glEvalCoord1f((GLfloat)i / 100.0);
    }
    glEnd();
}

void display()
{
    glClear(GL_COLOR_BUFFER_BIT);
    glColor3f(0.0, 0.0, 0.0); // Чорний колір

    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();

    drawGammaSymbol();

    glFlush();
}

void reshape(int width, int height)
{
    glViewport(0, 0, width, height);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluOrtho2D(-1.0, 1.0, -1.0, 1.0);
    glMatrixMode(GL_MODELVIEW);
}

int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    glutInitWindowSize(800, 600);
    glutCreateWindow("Лабораторна no. 5");
    glClearColor(1.0, 1.0, 1.0, 1.0); // Білий фон
    glShadeModel(GL_FLAT);

    glutDisplayFunc(display);
    glutReshapeFunc(reshape);

    glutMainLoop();

    return 0;
}
