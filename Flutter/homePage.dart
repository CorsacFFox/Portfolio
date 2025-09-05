import 'package:flutter/material.dart';
import 'package:atlas/defects.dart';
import 'package:atlas/listofdefects.dart';
import 'package:atlas/about.dart';
import 'package:atlas/advert.dart';

class MyApp extends StatelessWidget{
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: false,
        theme: ThemeData(primaryColor: Colors.blueGrey),
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
            //backgroundColor: Colors.indigo,
            actions: [
              //IconButton(onPressed: (){}, icon: const Icon(Icons.menu)),
              PopupMenuButton<int>(itemBuilder: (context)=>[
                const PopupMenuItem(
                  value: 1,
                  child: Row(
                    children: [
                      Text('Настройки'),
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
          ),
          body:

          Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              const SizedBox(height: 200),
              Center(
                child: SizedBox(
                  height: 32,
                  width: 200,
                  child: ElevatedButton(onPressed: (){
                    Navigator.push(context, MaterialPageRoute(builder: (context) => Defects(0)));
                  }, style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.deepOrange,
                  ), child: const Text('Изображения дефектов'),),
                )
              ),
              const SizedBox(height: 30),
              Center(
                child: SizedBox(
                  height: 32,
                  width: 200,
                  child: ElevatedButton(onPressed: (){
                    Navigator.push(context, MaterialPageRoute(builder: (context) => const DefectsList()));
                  }, style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.deepOrange,), child: const Text('Список дефектов')),
                ),

              ),


            ],
          ),
        )
    );
  }
}