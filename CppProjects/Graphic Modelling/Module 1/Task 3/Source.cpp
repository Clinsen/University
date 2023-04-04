#include <GL/glut.h>
#include <cmath>

void display() {
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();
    gluLookAt(0, 0, 5, 0, 0, 0, 0, 1, 0); // Set camera position and orientation

    glBegin(GL_TRIANGLE_FAN); // Draw base face
    glColor3f(1, 1, 0.31); // Set figure color to F6FF4F
    glVertex3f(0, -1, 0); // Center vertex
    for (int i = 0; i <= 5; i++) {
        float angle = i * 2 * 3.14159 / 5;
        glVertex3f(0.95 * sin(angle), -1, 0.95 * cos(angle)); // Vertices of the base face
    }
    glEnd();

    glBegin(GL_TRIANGLE_FAN); // Draw top face
    glColor3f(1, 1, 0.31); // Set figure color to F6FF4F
    glVertex3f(0, 1, 0); // Center vertex
    for (int i = 0; i <= 5; i++) {
        float angle = i * 2 * 3.14159 / 5;
        glVertex3f(0.95 * sin(angle), 1, 0.95 * cos(angle)); // Vertices of the top face
    }
    glEnd();

    glBegin(GL_QUADS); // Draw side faces
    glColor3f(1, 1, 0.31); // Set figure color to F6FF4F
    for (int i = 0; i < 5; i++) {
        float angle1 = i * 2 * 3.14159 / 5;
        float angle2 = (i + 1) * 2 * 3.14159 / 5;
        glVertex3f(0.95 * sin(angle1), -1, 0.95 * cos(angle1)); // Bottom left vertex
        glVertex3f(0.95 * sin(angle2), -1, 0.95 * cos(angle2)); // Bottom right vertex
        glVertex3f(0.95 * sin(angle2), 1, 0.95 * cos(angle2)); // Top right vertex
        glVertex3f(0.95 * sin(angle1), 1, 0.95 * cos(angle1)); // Top left vertex
    }
    glEnd();

    glutSwapBuffers();
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_RGBA | GLUT_DOUBLE | GLUT_DEPTH);
    glutInitWindowSize(640, 480);
    glutCreateWindow("3D Prism");
    glutDisplayFunc(display);
    glEnable(GL_DEPTH_TEST);
    glClearColor(0, 1, 0, 1); // Set background color to 00FF00
    glutMainLoop();
    return 0;
}



