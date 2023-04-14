#include <GL/glut.h> 
#define _USE_MATH_DEFINES
#include <math.h>
#include <iostream>
#include <string>
#include <sstream>
#include <fstream>
#include <vector>
using namespace std;

//camera rotation
GLfloat rotationX = 0.0f;
GLfloat rotationY = 0.0f;

//camera zoom
GLfloat zoom = 1.0f;


class Renderer {

public:
    float t;
private:
    GLuint texID;

public:
    Renderer() : t(0.0), texID(0) {}

    ~Renderer() 
    {
        if (texID != 0) glDeleteTextures(1, &texID);
    }

public:
    void init() {
        glEnable(GL_DEPTH_TEST);
        std::string fileName("texture.ppm");
        texID = loadTexture(fileName);
    }

    void resize(int w, int h) {
        glViewport(0, 0, w, h);
        glMatrixMode(GL_PROJECTION);
        glLoadIdentity();
        gluPerspective(30.0, (float)w / (float)h, 0.1, 50.0);
    }

    void display() {
        glClearColor(0.6, 0.9, 1.0, 1.0);
        glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

        glMatrixMode(GL_MODELVIEW);
        glLoadIdentity();
        glTranslatef(0.0f, 0.0f, -5.0f / zoom);
        glRotatef(rotationX, 1.0f, 0.0f, 0.0f);
        glRotatef(rotationY, 0.0f, 1.0f, 0.0f);
        drawTextured();
    }

private:
    // Returns a valid textureID on success, otherwise 0
    GLuint loadTexture(std::string& filename) {

        unsigned width;
        unsigned height;
        int level = 0;
        int border = 0;
        std::vector<unsigned char> imgData;

        // Load image data
        if (!loadPPMImageFlipped(filename, width, height, imgData)) return 0;

        // Data is aligned in byte order
        glPixelStorei(GL_UNPACK_ALIGNMENT, 1);

        // Request textureID
        GLuint textureID;
        glGenTextures(1, &textureID);

        // Bbind texture
        glBindTexture(GL_TEXTURE_2D, textureID);

        // Define how to filter the texture (important but ignore for now)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);

        // Texture colors should replace the original color values
        glTexEnvf(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_REPLACE); //GL_MODULATE

        // Specify the 2D texture map
        glTexImage2D(GL_TEXTURE_2D, level, GL_RGB, width, height, border, GL_RGB, GL_UNSIGNED_BYTE, &imgData[0]);

        // Return unique texture identifier
        return textureID;
    }

    void drawTextured() {
        glEnable(GL_TEXTURE_2D);

        glBindTexture(GL_TEXTURE_2D, texID);
        //glColor3f(0, 0, 0);

        //glBegin(GL_POLYGON); // top
        //glTexCoord2f(0.0f, 0.0f); glVertex3f(-1.0f, 1.0f, 1.0f); // vertex A
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(-0.5f, 1.0f, 0.0f); // vertex B
        //glTexCoord2f(1.0f, 1.0f); glVertex3f(0.5f, 1.0f, 0.0f); // vertex C
        //glTexCoord2f(1.0f, 0.0f); glVertex3f(1.0f, 1.0f, 1.0f); // vertex D
        //glTexCoord2f(0.5f, 0.5f); glVertex3f(0.0f, 1.0f, 1.5f); // vertex E
        //glEnd();

        //glBegin(GL_LINES);

        //glTexCoord2f(0.0f, 0.0f); glVertex3f(-1.0f, 1.0f, 1.0f); // vertex A
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(-1.0f, -1.0f, 1.0f); // vertex F
        //glTexCoord2f(0.0f, 0.0f); glVertex3f(-0.5f, 1.0f, 0.0f); // vertex B
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(-0.5f, -1.0f, 0.0f); // vertex G
        //glTexCoord2f(0.0f, 0.0f); glVertex3f(0.5f, 1.0f, 0.0f); // vertex C
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(0.5f, -1.0f, 0.0f); // vertex H
        //glTexCoord2f(0.0f, 0.0f); glVertex3f(1.0f, 1.0f, 1.0f); // vertex D
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(1.0f, -1.0f, 1.0f); // vertex I
        //glTexCoord2f(0.0f, 0.0f); glVertex3f(0.0f, 1.0f, 1.5f); // vertex E
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(0.0f, -1.0f, 1.5f); // vertex J
        //glEnd();

        //glBegin(GL_POLYGON); // top
        //glTexCoord2f(0.0f, 0.0f); glVertex3f(-1.0f, -1.0f, 1.0f); // vertex A
        //glTexCoord2f(0.0f, 1.0f); glVertex3f(-0.5f, -1.0f, 0.0f); // vertex B
        //glTexCoord2f(1.0f, 1.0f); glVertex3f(0.5f, -1.0f, 0.0f); // vertex C
        //glTexCoord2f(1.0f, 0.0f); glVertex3f(1.0f, -1.0f, 1.0f); // vertex D
        //glTexCoord2f(0.5f, 0.5f); glVertex3f(0.0f, -1.0f, 1.5f); // vertex E
        //glEnd();

        glBegin(GL_TRIANGLES);
        glTexCoord2f(0.0f, 0.0f); glVertex2f(-0.5f, -0.5f); // bottom-left vertex
        glTexCoord2f(0.0f, 1.0f); glVertex2f(0.5f, -0.5f); // bottom-right vertex
        glTexCoord2f(1.0f, 0.0f);  glVertex2f(0.0f, 0.5f); // top vertex
        glEnd();

        glDisable(GL_TEXTURE_2D);
    }

    bool loadPPMImageFlipped(std::string& filename, unsigned& width, unsigned& height, std::vector<unsigned char>& imgData) {

        ifstream input(filename.c_str(), ifstream::in | ifstream::binary);
        if (!input) { // Cast istream to bool to see if something went wrong
            cerr << "Can not find texture data file " << filename.c_str() << endl;
            return false;
        }
        input.unsetf(std::ios_base::skipws);

        string line;
        input >> line >> std::ws;
        if (line != "P6") {
            cerr << "File is not PPM P6 raw format" << endl;
            return false;
        }

        width = 0;
        height = 0;
        unsigned depth = 0;
        unsigned readItems = 0;
        unsigned char lastCharBeforeBinary;

        while (readItems < 3) {
            input >> std::ws;
            if (input.peek() != '#') {
                if (readItems == 0) input >> width;
                if (readItems == 1) input >> height;
                if (readItems == 2) input >> depth >> lastCharBeforeBinary;
                readItems++;
            }
            else { // Skip comments
                std::getline(input, line);
            }
        }

        if (depth >= 256) {
            cerr << "Only 8-bit PPM format is supported" << endl;
            return false;
        }

        unsigned byteCount = width * height * 3;
        imgData.resize(byteCount);
        input.read((char*)&imgData[0], byteCount * sizeof(unsigned char));

        // Vertically flip the image because the image origin
        // In OpenGL is the lower-left corner
        unsigned char tmpData;
        for (unsigned y = 0; y < height / 2; y++) {
            int sourceIndex = y * width * 3;
            int targetIndex = (height - 1 - y) * width * 3;
            for (unsigned x = 0; x < width * 3; x++) {
                tmpData = imgData[targetIndex];
                imgData[targetIndex] = imgData[sourceIndex];
                imgData[sourceIndex] = tmpData;
                sourceIndex++;
                targetIndex++;
            }
        }

        return true;
    }
};

// Tis is a static pointer to a Renderer used in the glut callback functions
static Renderer* renderer;

// Glut static callbacks start
static void glutResize(int w, int h)
{
    renderer->resize(w, h);
}

static void glutDisplay()
{
    renderer->display();
    glutSwapBuffers();
    glutReportErrors();
}

//static void timer(int v)
//{
//    float offset = 1.0f;
//    renderer->t += offset;
//    glutDisplay();
//    glutTimerFunc(unsigned(20), timer, ++v);
//}

void keyboard(unsigned char key, int x, int y)
{
    switch (key)
    {
        // Rotate up
    case GLUT_KEY_UP:
        rotationX -= 5.0f;
        break;

        // Rotate down
    case GLUT_KEY_DOWN:
        rotationX += 5.0f;
        break;

        // Rotate left
    case GLUT_KEY_LEFT:
        rotationY -= 5.0f;
        break;

        // Rotate right
    case GLUT_KEY_RIGHT:
        rotationY += 5.0f;
        break;

        // Zoom in
    case '+':
        zoom *= 1.1f;
        break;

        // Zoom out
    case '-':
        zoom /= 1.1f;
        break;
    default:
        break;
    }


    glutPostRedisplay();
}



int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_DEPTH | GLUT_DOUBLE | GLUT_RGBA);
    glutInitWindowPosition(100, 100);
    glutInitWindowSize(800, 600);

    glutCreateWindow("Laboratorna no. 3");

    glutDisplayFunc(glutDisplay);

    glutReshapeFunc(glutResize);

    renderer = new Renderer;
    renderer->init();

    //glutTimerFunc(unsigned(20), timer, 0);
    glutKeyboardFunc(keyboard);
    glutMainLoop();
}
