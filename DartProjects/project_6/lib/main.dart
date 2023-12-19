import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Лабораторна №6',
      home: Scaffold(
        body: Column(
          children: <Widget>[
            Row(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                Container(
                  margin: const EdgeInsets.only(left: 150.0),
                  padding: const EdgeInsets.all(10),
                  width: 450.0,
                  height: 250.0,
                  decoration: BoxDecoration(
                    color: Colors.yellow,
                    border: Border.all(
                      color: Colors.black,
                      width: 2.0,
                    ),
                  ),
                  child: const Text(
                    'Ще не вмерла Україна, і слава, і воля, ще нам браття молодії усміхнеться доля.',
                    textAlign: TextAlign.justify,
                    style: TextStyle(color: Colors.black, fontSize: 12.0),
                  ),
                ),
                Container(
                  margin: const EdgeInsets.only(left: 20.0, right: 100.0),
                  padding: const EdgeInsets.all(10),
                  width: 500.0,
                  height: 250.0,
                  decoration: BoxDecoration(
                    color: Colors.blue,
                    border: Border.all(
                      color: Colors.black,
                      width: 2.0,
                    ),
                  ),
                  child: const Text(
                    'Згинуть наші вороженьки як роса на сонці, запануєм і ми, браття, у своїй сторонці.',
                    textAlign: TextAlign.justify,
                    style: TextStyle(color: Colors.black, fontSize: 12.0),
                  ),
                ),
              ],
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                Container(
                  margin: const EdgeInsets.only(left: 100.0, right: 100.0, top: 150),
                  padding: const EdgeInsets.only(left: 3, top: 5, right: 4, bottom: 5),
                  width: 200.0,
                  height: 150.0,
                  decoration: BoxDecoration(
                    color: Colors.white,
                    border: Border.all(
                      color: Colors.black,
                      width: 2.0,
                    ),
                  ),
                  child: Container(
                    margin: const EdgeInsets.only(left: 20.0, right: 100.0),
                    padding: const EdgeInsets.all(10),
                    width: 200.0,
                    height: 150.0,
                    decoration: BoxDecoration(
                      color: Colors.white,
                      border: Border.all(
                        color: Colors.black,
                        width: 2.0,
                      ),
                    ),
                    child: const Text(
                      'Душу й тіло ми положим за нашу свободу.',
                      textAlign: TextAlign.justify,
                      style: TextStyle(color: Colors.black, fontSize: 12.0),
                    ),
                  ),
                ),
                Container(
                  margin: const EdgeInsets.only(left: 20.0, right: 100.0, top: 150),
                  padding: const EdgeInsets.all(10),
                  width: 200.0,
                  height: 150,
                  decoration: BoxDecoration(
                    color: Colors.white,
                    border: Border.all(
                      color: Colors.black,
                      width: 2.0,
                    ),
                  ),
                  child: const Text(
                    'І покажем що ми браття козацького роду.',
                    textAlign: TextAlign.justify,
                    style: TextStyle(color: Colors.black, fontSize: 12.0),
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}