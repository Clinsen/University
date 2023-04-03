#include <windows.h>
#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>


// Prototypes
void display();
void init();
void reshape(int, int);
void specialKeys(int, int, int);


// Global variables
float angle = 0.0; // current angle of the object
float zoom = -7.5; // current zoom level of the camera


// Main
int main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);

	glutInitWindowPosition(200, 100);
	glutInitWindowSize(500, 500);

	glutCreateWindow("Laboratorna no. 2");
	glEnable(GL_DEPTH_TEST);

	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	glutSpecialFunc(specialKeys);
	init();

	glutMainLoop();
}


void display()
{
	// Clear the frame buffer before drawing
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);


	// Necessary for perspective matrix
	glMatrixMode(GL_PROJECTION);


	// Reset the coordinate system
	glLoadIdentity();


	// Define the perspective matrix using gluPerspective
	gluPerspective(45.0, (double)glutGet(GLUT_WINDOW_WIDTH) / (double)glutGet(GLUT_WINDOW_HEIGHT), 1.0, 10.0);
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();


	// Apply camera transformations
	glTranslatef(0.0, 0.0, zoom);


	// Apply modeling transformations to the object
	glRotatef(angle, 0.0, 1.0, 0.0);
	glScalef(2.0, 2.0, 2.0);


	// Draw the 3D object here
	glBegin(GL_TRIANGLES);
	glColor3f(1.0, 0.0, 0.0); // Red
	glVertex3f(-1.0, -1.0, 0.0);
	glVertex3f(1.0, -1.0, 0.0);
	glVertex3f(0.0, 1.0, 0.0);

	glColor3f(0.0, 1.0, 0.0); // Green
	glVertex3f(-1.0, -1.0, 0.0);
	glVertex3f(0.0, -1.0, 1.0);
	glVertex3f(0.0, 1.0, 0.0);

	glColor3f(0.0, 0.0, 1.0); // Blue
	glVertex3f(1.0, -1.0, 0.0);
	glVertex3f(0.0, -1.0, 1.0);
	glVertex3f(0.0, 1.0, 0.0);

	glColor3f(1.0, 0.0, 1.0); // Magenta
	glVertex3f(-1.0, -1.0, 0.0);
	glVertex3f(0.0, -1.0, -1.0);
	glVertex3f(0.0, 1.0, 0.0);

	glColor3f(0.0, 1.0, 1.0); // Cyan
	glVertex3f(1.0, -1.0, 0.0);
	glVertex3f(0.0, -1.0, -1.0);
	glVertex3f(0.0, 1.0, 0.0);

	glColor3f(1.0, 1.0, 0.0); // Yellow
	glVertex3f(0.0, -1.0, 1.0);
	glVertex3f(0.0, -1.0, -1.0);
	glVertex3f(-1.0, -1.0, 0.0);
	glEnd();


	glutSwapBuffers();
}


void specialKeys(int key, int x, int y)
{
	switch (key)
	{
	case GLUT_KEY_LEFT:
		angle -= 5.0;
		break;
	case GLUT_KEY_RIGHT:
		angle += 5.0;
		break;
	case GLUT_KEY_UP:
		zoom += 0.1;
		break;
	case GLUT_KEY_DOWN:
		zoom -= 0.1;
		break;
	}
	glutPostRedisplay();
}


void init()
{
	glClearColor(0.0, 0.0, 0.0, 1.0);
	glEnable(GL_DEPTH_TEST);
}


void reshape(int w, int h)
{
	glViewport(0, 0, (GLsizei)w, (GLsizei)h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(-10, 10, -10, 10);
	glMatrixMode(GL_MODELVIEW);
}