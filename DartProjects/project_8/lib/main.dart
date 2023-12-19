import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp(
    title: 'Лабораторна №8',
    description: 'Простий проект з кастомним віджетом',
    buttonText: 'Натисни на мене',
  ));
}

class MyApp extends StatelessWidget {
  final String title;
  final String description;
  final String buttonText;

  const MyApp({
    Key? key,
    required this.title,
    required this.description,
    required this.buttonText,
  }) : super(key: key); // MyApp

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(
          title: Text(title),
          centerTitle: true, // AppBar
        ),
        body: Center(
          child: CustomMaterialWidget( // Center
            description: description,
            buttonText: buttonText,
          ),
        ),
      ),
    );
  }
}

class CustomMaterialWidget extends StatelessWidget {
  final String description;
  final String buttonText;

  const CustomMaterialWidget({
    Key? key,
    required this.description,
    required this.buttonText,
  }) : super(key: key); // CustomMaterialWidget

  @override
  Widget build(BuildContext context) {
    return Container( // Container
      padding: const EdgeInsets.all(16),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Text(
            description, // Text
            style: const TextStyle(fontSize: 18),
            textAlign: TextAlign.center,
          ),
          const SizedBox(height: 20),
          ElevatedButton(
            onPressed: () {
              ScaffoldMessenger.of(context).showSnackBar(
                const SnackBar(
                  content: Text('Кнопка натиснута.'),
                ),
              );
            },
            child: Text(buttonText),
          ),
        ],
      ),
    ); // Container
  }
}
