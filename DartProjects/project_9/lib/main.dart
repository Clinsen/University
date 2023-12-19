import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp(
    title: 'Лабораторна №9',
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
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(
          title: Text(title),
          centerTitle: true,
        ),
        body: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              CustomMaterialWidget(
                description: description,
                buttonText: buttonText,
              ),
              const SizedBox(height: 20),
              CounterWidget(),
            ],
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
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(16),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Text(
            description,
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
    );
  }
}

class CounterWidget extends StatefulWidget {
  @override
  _CounterWidgetState createState() => _CounterWidgetState();
}

class _CounterWidgetState extends State<CounterWidget> {
  int counter = 0;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Text(
          'Лічильник: $counter',
          style: const TextStyle(fontSize: 18),
        ),
        const SizedBox(height: 10),
        ElevatedButton(
          onPressed: () {
            setState(() {
              counter++;
            });
          },
          child: const Text('Збільшити лічильник'),
        ),
      ],
    );
  }
}
