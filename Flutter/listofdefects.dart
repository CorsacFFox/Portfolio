import 'package:flutter/material.dart';
import 'package:atlas/defects.dart';
import 'package:atlas/about.dart';
import 'package:atlas/advert.dart';
import 'package:atlas/homePage.dart';

class DefectsList extends StatelessWidget{
  const DefectsList({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: false,
        theme: ThemeData(
          primaryColor: Colors.indigo,
          //primarySwatch: Colors.indigo,
        ),
        home: Scaffold(
          appBar: AppBar(
            flexibleSpace: Container(
              decoration: const BoxDecoration(
                gradient: LinearGradient(
                    begin: Alignment.centerLeft,
                    end: Alignment.centerRight,
                    colors: [Colors.red, Colors.deepOrange]),
              ),
            ),
            actions: [
              //IconButton(onPressed: (){}, icon: const Icon(Icons.menu)),
              PopupMenuButton<int>(itemBuilder: (context)=>[
                PopupMenuItem(
                  value: 0,
                  onTap: (){Navigator.push(context, MaterialPageRoute(builder: (context) => const MyApp()));},
                  child: const Row(
                    children: [
                      Text('На главную')
                    ],
                  ),),
                const PopupMenuItem(
                  value: 1,
                  child: Row(
                    children: [
                      Text('Настройки')
                    ],
                  ),),
                PopupMenuItem(
                  value: 2,
                  onTap: (){Navigator.push(context, MaterialPageRoute(builder: (context) => const About()));},
                  child: const Row(
                    children: [
                      Text('О программе')
                    ],
                  ),
                ),
                PopupMenuItem(
                  value: 3,
                  onTap: (){Navigator.push(context, MaterialPageRoute(builder: (context) => const Advert()));},
                  child: const Row(
                    children: [
                      Text('АСК-РЕНТГЕН')
                    ],
                  ),
                )
              ])
            ],
            toolbarHeight: 70,
            centerTitle: true,
            title: const Text('РАСШИФРОВКА РЕПРОДУКЦИЙ РАДИОГРАФИЧЕСКИХ СНИМКОВ', maxLines: 2, textAlign: TextAlign.center, style: TextStyle(
              fontSize: 16,
              fontFamily: 'Arial',
            )),
            leading: BackButton(
                color: Colors.white,
                onPressed: (){Navigator.pop(context);}
            ),
          ),
          body: SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.fromLTRB(10, 0, 0, 0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  const Padding(
                    padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: Text('Список дефектов', style: TextStyle(
                      fontSize: 20,
                      fontFamily: 'Arial',
                      fontWeight: FontWeight.bold,
                      color: Colors.indigo
                    )),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton (
                      child: const Text("1. Смещение кромок"),
                      onPressed: () {
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(0)));
                      },
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton(
                      onPressed: (){
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(1)));
                      },
                      child: const Text('2. Test'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton(
                      onPressed: (){
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(2)));
                      },
                      child: const Text('3. Privet'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton(
                      onPressed: (){
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(3)));
                      },
                      child: const Text('4. Poka'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton(
                      onPressed: (){
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(4)));
                      },
                      child: const Text('5. Zdravstvuy'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton(
                      onPressed: (){
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(5)));
                      },
                      child: const Text('6. Hello'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                    child: TextButton(
                      onPressed: (){
                        Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(6)));
                      },
                      child: const Text('7. Ciao'),
                    ),
                  ),
                ],


              ),

            )

          ),



        )
    );
  }
}