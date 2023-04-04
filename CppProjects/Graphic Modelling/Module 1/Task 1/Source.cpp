#include <windows.h>
#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>

void display();
void init();
void reshape(int, int);

int main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_RGB);

	glutInitWindowPosition(200, 100);
	glutInitWindowSize(500, 500);

	glutCreateWindow("Task no. 1");

	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	init();

	glutMainLoop();
}

void display()
{
	// Clear the frame buffer before drawing
	glClear(GL_COLOR_BUFFER_BIT);

	// Reset the coordinate system
	glLoadIdentity();

	// Draw stuff here
	// Lines (Pentagram)
	glEnable(GL_LINE_SMOOTH);

	glColor3f(0, 0, 0);
	glLineWidth(3);
	glBegin(GL_LINE_LOOP);

	glVertex2f(-2, -6);
	glVertex2f(2, 6);
	glVertex2f(6, -6);
	glVertex2f(-4, 2);
	glVertex2f(8, 2);

	glEnd();

	glDisable(GL_LINE_SMOOTH);

	// Displays frame buffer on the screen
	glFlush();
}

void init()
{
	glClearColor(0.6, 0.9, 1.0, 1.0);
}

void reshape(int w, int h)
{
	glViewport(0, 0, (GLsizei)w, (GLsizei)h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(-10, 10, -10, 10);
	glMatrixMode(GL_MODELVIEW);
}