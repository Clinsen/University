#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>

// Рівень глобального фонового світла
GLfloat ambientLight[] = { 0.5f, 0.5f, 0.5f, 1.0f };

// Положення точки спостереження
GLfloat eyePosition[] = { 0.0f, 0.0f, 10.0f, 1.0f };

// Параметри матеріалу кола
GLfloat silverMaterial[] = { 0.75f, 0.75f, 0.75f, 1.0f };

void display() {
    // Очищення буфера кольорів і буфера глибини
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

    // Налаштування параметрів освітлення
    glLightModelfv(GL_LIGHT_MODEL_AMBIENT, ambientLight);
    glLightfv(GL_LIGHT0, GL_POSITION, eyePosition);
    glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);

    // Налаштування параметрів матеріалу кола
    glMaterialfv(GL_FRONT_AND_BACK, GL_AMBIENT_AND_DIFFUSE, silverMaterial);
    glMaterialfv(GL_FRONT_AND_BACK, GL_SPECULAR, silverMaterial);
    glMaterialf(GL_FRONT_AND_BACK, GL_SHININESS, 50.0f);

    // Відображення кола
    glutSolidSphere(1.0, 20, 20);

    // Завершення візуалізації кадру
    glutSwapBuffers();
}

int main(int argc, char** argv) {
    // Ініціалізація GLUT
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
    glutInitWindowSize(640, 480);
    glutCreateWindow("Circle Demo");

    // Налаштування параметрів OpenGL
    glEnable(GL_DEPTH_TEST);
    glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

    // Реєстрація функції відображення
    glutDisplayFunc(display);

    // Запуск головного циклу GLUT
    glutMainLoop();
    return 0;
}