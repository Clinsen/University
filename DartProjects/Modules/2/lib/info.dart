import 'package:flutter/material.dart';

class AnimalInfo {
  final String name;
  final String imageAsset;
  final String description;

  AnimalInfo({
    required this.name,
    required this.imageAsset,
    required this.description,
  });
}

final List<AnimalInfo> myAnswers = [
  AnimalInfo(
    name: 'Теорія №1',
    imageAsset: 'assets/img/pokemon.jpg',
    description: 'ConstrainedBox дозволяє обмежити розмір дочірніх віджетів. '
        'Такими віджетами можуть виступати контейнери чи зображення. Щоб ним '
        'скористатися достатньо огорнути наш елемент в ConstrainedBox() і задати '
        'йому необхідні параметри, наприклад MaxWidth та MaxHeight',
  ),
  AnimalInfo(
    name: 'Теорія №2',
    imageAsset: 'assets/img/pokemon.jpg',
    description: 'TextFormField() обгортає віджет TextField у FormField щоб надати йому '
        'додатковий функціонал. Таким функціоналом дуже часто виступає валідація введених даних: '
        'чи поле не порожнє, чи може існувати той чи інший електроний адрес, чи збігається пароль '
        'з тим, який було задано в полі вище (ф-ція підтвердження паролю), тощо.',
  ),
  AnimalInfo(
    name: 'Зебра',
    imageAsset: 'assets/img/pokemon.jpg',
    description: 'Це Зебра.',
  ),
  AnimalInfo(
    name: 'Капібара',
    imageAsset: 'assets/img/pokemon.jpg',
    description: 'Це Капібара.',
  ),
  AnimalInfo(
    name: 'Коала',
    imageAsset: 'assets/img/pokemon.jpg',
    description: 'Це Коала.',
  ),
];

class AnimalsListPage extends StatefulWidget {
  const AnimalsListPage({Key? key}) : super(key: key);

  @override
  _AnimalsListPageState createState() => _AnimalsListPageState();
}

class _AnimalsListPageState extends State<AnimalsListPage> {
  final TextEditingController _newAnimalController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Модульна контрольна робота №2'),
      ),
      body: Column(
        children: [
          Expanded(
            child: ListView.builder(
              itemCount: myAnswers.length,
              itemBuilder: (context, index) {
                return Column(
                  children: [
                    ListTile(
                      leading: CircleAvatar(
                        backgroundImage: AssetImage(myAnswers[index].imageAsset),
                      ),
                      title: Text(myAnswers[index].name),
                      onTap: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) => AnimalDetailPage(animal: myAnswers[index]),
                          ),
                        );
                      },
                    ),
                    const Divider(
                      height: 10.0,
                      thickness: 2.0,
                      color: Colors.grey,
                      indent: 20.0,
                      endIndent: 20.0,
                    ),
                  ],
                );
              },
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                Expanded(
                  child: TextFormField(
                    controller: _newAnimalController,
                    decoration: const InputDecoration(
                      hintText: 'Назва нової тварини',
                    ),
                  ),
                ),
                IconButton(
                  icon: const Icon(Icons.add),
                  onPressed: () {
                    String newAnimalName = _newAnimalController.text.trim();
                    if (newAnimalName.isNotEmpty) {
                      setState(() {
                        myAnswers.add(
                          AnimalInfo(
                            name: newAnimalName,
                            imageAsset: 'assets/img/pokemon.jpg',
                            description: 'Це $newAnimalName.',
                          ),
                        );
                        _newAnimalController.clear();
                      });
                    } else {
                      showDialog(
                        context: context,
                        builder: (BuildContext context) {
                          return AlertDialog(
                            title: const Text('Пусте поле введення'),
                            content: const Text('Будь ласка, введіть назву тварини перед додаванням.'),
                            actions: [
                              TextButton(
                                onPressed: () {
                                  Navigator.of(context).pop();
                                },
                                child: const Text('OK'),
                              ),
                            ],
                          );
                        },
                      );
                    }
                  },
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}

class AnimalDetailPage extends StatelessWidget {
  final AnimalInfo animal;

  const AnimalDetailPage({Key? key, required this.animal}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(animal.name),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Text(animal.description),
          ],
        ),
      ),
    );
  }
}
