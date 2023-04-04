#include <windows.h>
#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>
#include <cmath>

float angle = 0.0;
float rotateSpeed = 0.10;
float orbitSpeed = 0.04;
float orbitRadius = 5.0;
float orbitCenterX = 0.0;
float orbitCenterY = 0.0;
float orbitCenterZ = 0.0;

void display();
void init();
void reshape(int, int);
void update(int);

int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE | GLUT_DEPTH);
    glutInitWindowPosition(200, 100);
    glutInitWindowSize(500, 500);
    glutCreateWindow("Task no. 2");
    glutDisplayFunc(display);
    glutReshapeFunc(reshape);
    init();
    glutTimerFunc(0, update, 0);
    glutMainLoop();
}

void display()
{
    // Clear the frame buffer before drawing
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

    // Reset the coordinate system
    glLoadIdentity();

    // Set up the camera position
    gluLookAt(0.0, 0.0, 10.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);

    // Draw the cube
    glColor3f(0, 0, 0);
    glPushMatrix();
    glTranslatef(orbitCenterX, orbitCenterY, orbitCenterZ);
    glRotatef(angle, 0.0, 1.0, 0.0);
    glutWireCube(2.0);
    glPopMatrix();

    // Displays frame buffer on the screen
    glutSwapBuffers();
}

void init()
{
    glClearColor(0.6, 0.9, 1.0, 1.0);
    glEnable(GL_DEPTH_TEST);
}

void reshape(int w, int h)
{
    glViewport(0, 0, (GLsizei)w, (GLsizei)h);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(60.0, (GLfloat)w / (GLfloat)h, 1.0, 100.0);
    glMatrixMode(GL_MODELVIEW);
}

void update(int value)
{
    // Update the angle of rotation
    angle += rotateSpeed;

    // Update the position of the cube
    float x = orbitRadius * cos(angle * orbitSpeed);
    float z = orbitRadius * sin(angle * orbitSpeed);
    orbitCenterX = x;
    orbitCenterZ = z;

    // Render the scene
    glutPostRedisplay();

    // Call update() again in 10 milliseconds
    glutTimerFunc(10, update, 0);
}