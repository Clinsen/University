#include <GL/glut.h>

GLfloat controlPoints[][3] = {
    { -0.6, 0.2, 0.0 },
    { -0.2, 0.8, 0.0 },
    { -0.2, -0.2, 0.0 },
    { -0.8, -0.8, 0.0 },
    { -0.2, -0.8, 0.0 },
    { -0.2, -0.6, 0.0 },
    { 0.8, -1.4, 0.0 },
    { 0.8, -0.6, 0.0 },
    { 0.2, -0.8, 0.0 },
    { 0.2, -0.2, 0.0 },
    { 0.8, -0.2, 0.0 },
    { 0.8, 0.2, 0.0 },
    { 0.6, 0.8, 0.0 }
};

void drawCurve() {
    glPushMatrix();
    glColor3f(0.0, 0.0, 0.0); // Встановлення чорного кольору лінії
    glBegin(GL_LINE_STRIP);
    for (float t = 0.0; t <= 1.0; t += 0.01) {
        // Розрахунок координати точки кривої
        float x = (1 - t) * (1 - t) * (1 - t) * (1 - t) * (1 - t) * controlPoints[0][0]
            + 5 * t * (1 - t) * (1 - t) * (1 - t) * (1 - t) * controlPoints[1][0]
            + 10 * t * t * (1 - t) * (1 - t) * (1 - t) * controlPoints[2][0]
            + 10 * t * t * t * (1 - t) * (1 - t) * controlPoints[3][0]
            + 5 * t * t * t * t * (1 - t) * controlPoints[4][0]
            + t * t * t * t * t * controlPoints[5][0];

        float y = (1 - t) * (1 - t) * (1 - t) * (1 - t) * (1 - t) * controlPoints[0][1]
            + 5 * t * (1 - t) * (1 - t) * (1 - t) * (1 - t) * controlPoints[1][1]
            + 10 * t * t * (1 - t) * (1 - t) * (1 - t) * controlPoints[2][1]
            + 10 * t * t * t * (1 - t) * (1 - t) * controlPoints[3][1]
            + 5 * t * t * t * t * (1 - t) * controlPoints[4][1]
            + t * t * t * t * t * controlPoints[5][1];
        glVertex2f(x, y);
    }
    glEnd();
    glPopMatrix();
}

void display() {
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glLoadIdentity();
    drawCurve();
    glFlush();
}

void reshape(int width, int height) {
    glViewport(0, 0, width, height);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluOrtho2D(-1.0, 1.0, -1.0, 1.0);
    glMatrixMode(GL_MODELVIEW);
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_RGB | GLUT_SINGLE);
    glutInitWindowSize(400, 300);
    glutCreateWindow("Task no. 3");
    glClearColor(0.6, 0.9, 1.0, 1.0);
    glutDisplayFunc(display);
    glutReshapeFunc(reshape);
    glutMainLoop();
    return 0;
}

