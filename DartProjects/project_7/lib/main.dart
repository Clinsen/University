import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  final double baseSquareSize = 500;
  final double a = 24;
  final double b = 34;
  final double c = 64;

  const MyApp({Key? key}) : super(key: key);

  double sc() => a + b;
  double tc() => a + b + c;

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Лабораторна №7',
      home: Scaffold(
        body: Center(
          child: Stack(
            alignment: Alignment.bottomRight,
            children: <Widget>[
              Container(
                width: baseSquareSize,
                height: baseSquareSize,
                color: Colors.yellow,
              ),
              Positioned(
                top: a,
                left: a,
                child: Container(
                  width: baseSquareSize - a,
                  height: baseSquareSize - a,
                  color: Colors.red,
                  child: const Align(
                    alignment: Alignment.topCenter,
                    child: Padding(
                      padding: EdgeInsets.only(top: 10.0, left: 120.0),
                      child: Text(
                        'Hello',
                        style: TextStyle(
                          fontStyle: FontStyle.italic,
                          color: Colors.white,
                          fontSize: 50,
                        ),
                      ),
                    ),
                  ),
                ),
              ),
              Positioned(
                top: tc(),
                left: tc(),
                child: Container(
                  width: baseSquareSize - tc(),
                  height: baseSquareSize - tc(),
                  color: Colors.blue,
                  child: const Align(
                    alignment: Alignment.bottomRight,
                    child: Padding(
                      padding: EdgeInsets.only(bottom: 10.0, right: 10.0),
                      child: Text(
                        'Flutter',
                        style: TextStyle(
                          fontWeight: FontWeight.bold,
                          color: Colors.white,
                          fontSize: 50,
                        ),
                      ),
                    ),
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
