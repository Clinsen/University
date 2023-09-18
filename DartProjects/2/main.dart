import 'dart:io';


abstract class HomePet {
  String name;
  String breed;

  HomePet(this.name, this.breed);

  void makeSound();

  String getBreed(){
    return breed;
  }

  String getName(){
    return name;
  }

  void printInfo() {
    stdout.write('\nName: ${getName()}, Breed: ${getBreed()}\n');
  }
}


class Dog extends HomePet {
  Dog(String name, String breed) : super(name, breed);

  @override
  void makeSound() {
    print('$name says woof!');
  }
}


class Cat extends HomePet {
  Cat(String name, String breed) : super(name, breed);

  @override
  void makeSound() {
    print('$name says meow!');
  }
}


class Parrot extends HomePet {
  Parrot(String name, String breed) : super(name, breed);

  @override
  void makeSound() {
    print('$name says squawk!');
  }
}


void main() {
  Dog dog = Dog('Rex', 'Labrador');
  Cat cat = Cat('Fluffy', 'Scottish');
  Parrot parrot = Parrot('Kesha', 'Amazon');

  dog.printInfo();
  dog.makeSound();

  cat.printInfo();
  cat.makeSound();

  parrot.printInfo();
  parrot.makeSound();
}
