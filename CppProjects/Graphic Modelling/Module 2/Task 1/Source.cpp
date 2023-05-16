#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>

// г���� ����������� �������� �����
GLfloat ambientLight[] = { 0.5f, 0.5f, 0.5f, 1.0f };

// ��������� ����� �������������
GLfloat eyePosition[] = { 0.0f, 0.0f, 10.0f, 1.0f };

// ��������� �������� ����
GLfloat silverMaterial[] = { 0.75f, 0.75f, 0.75f, 1.0f };

void display() {
    // �������� ������ ������� � ������ �������
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

    // ������������ ��������� ���������
    glLightModelfv(GL_LIGHT_MODEL_AMBIENT, ambientLight);
    glLightfv(GL_LIGHT0, GL_POSITION, eyePosition);
    glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);

    // ������������ ��������� �������� ����
    glMaterialfv(GL_FRONT_AND_BACK, GL_AMBIENT_AND_DIFFUSE, silverMaterial);
    glMaterialfv(GL_FRONT_AND_BACK, GL_SPECULAR, silverMaterial);
    glMaterialf(GL_FRONT_AND_BACK, GL_SHININESS, 50.0f);

    // ³���������� ����
    glutSolidSphere(1.0, 20, 20);

    // ���������� ���������� �����
    glutSwapBuffers();
}

int main(int argc, char** argv) {
    // ����������� GLUT
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
    glutInitWindowSize(640, 480);
    glutCreateWindow("Circle Demo");

    // ������������ ��������� OpenGL
    glEnable(GL_DEPTH_TEST);
    glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

    // ��������� ������� �����������
    glutDisplayFunc(display);

    // ������ ��������� ����� GLUT
    glutMainLoop();
    return 0;
}