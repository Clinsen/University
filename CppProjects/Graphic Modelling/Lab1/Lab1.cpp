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

	glutCreateWindow("Laboratorna no. 1");

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
	// Points
	glColor3f(1, 1, 1);
	glPointSize(5);
	glBegin(GL_POINTS);
	
	glVertex2f(1, 1);
	glVertex2f(2, 1);
	glVertex2f(3, 1);
	glVertex2f(4, 1);
	glVertex2f(5, 1);

	glEnd();

	// Line
	glEnable(GL_LINE_SMOOTH);

	glLineWidth(5);
	glBegin(GL_LINES);
	
	glVertex2f(1, 2);
	glVertex2f(5, 2);

	glEnd();

	glDisable(GL_LINE_SMOOTH);

	// Triangle
	glColor3f(0.5, 0, 1);
	glBegin(GL_TRIANGLES);

	glVertex2f(-1, 1);
	glVertex2f(-1, 5);
	glVertex2f(-5, 5);

	glEnd();

	// Rectangle
	glColor3f(1, 1, 0);
	glBegin(GL_QUADS);

	glVertex2f(1, 3);
	glVertex2f(5, 3);
	glVertex2f(5, 5);
	glVertex2f(1, 5);

	glEnd();

	// Polygon
	glColor3f(0.5, 1, 0);
	glBegin(GL_POLYGON);

	glVertex2f(-5, 6);
	glVertex2f(-5, 8);
	glVertex2f(0, 9);
	glVertex2f(5, 8);
	glVertex2f(5, 6);

	glEnd();

	// Variant #6
	glColor3f(0.75, 0.2, 1);
	glBegin(GL_QUADS);

	glVertex2f(0, -3);
	glVertex2f(-3, -5);
	glVertex2f(0, -10);
	glVertex2f(3, -5);

	glEnd();

	glColor3f(0.75, 0.8, 1);
	glBegin(GL_QUADS);

	glVertex2f(-2, -4.4);
	glVertex2f(-2, -6.7);
	glVertex2f(2, -6.7);
	glVertex2f(2, -4.4);

	glEnd();

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