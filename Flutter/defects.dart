import 'package:flutter/material.dart';
import 'package:atlas/about.dart';
import 'package:atlas/advert.dart';
import 'package:atlas/homePage.dart';

const _StyleNormal = TextStyle(
  fontSize: 14,
  fontFamily: 'Arial',
  fontWeight: FontWeight.normal,
);

class Defects extends StatelessWidget {
  //const Defects({super.key});
  int selectedPage;
  Defects(this.selectedPage, {super.key});
  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
      initialIndex: selectedPage,
      length: 7,
      child: Scaffold(
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
            bottom: const TabBar(
              indicatorColor: Colors.white,
              isScrollable: true,
              labelPadding: EdgeInsets.symmetric(horizontal: 40.0),
              tabs: [
                Tab(icon: Text('1')),
                Tab(icon: Text('2')),
                Tab(icon: Text('3')),
                Tab(icon: Text('4')),
                Tab(icon: Text('5')),
                Tab(icon: Text('6')),
                Tab(icon: Text('7')),
              ],
            ),
            title: const Text('Изображения дефектов'),
            leading: BackButton(
                color: Colors.white,
                onPressed: (){Navigator.pop(context);}
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
          ),


          body: const TabBarView(
          children: [
             SingleChildScrollView(

              child: Padding(
                padding: EdgeInsets.fromLTRB(10, 0, 0, 0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Смещение кромок', style: TextStyle(
                        fontSize: 20,
                        fontFamily: 'Arial',
                        fontWeight: FontWeight.bold,
                      )),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Описание дефекта:', textAlign: TextAlign.left,style: TextStyle(
                        fontSize: 16,
                        fontFamily: 'Arial',
                        fontWeight: FontWeight.bold,
                      )),
                    ),


                    Text('Сваренные детали смещены', style: _StyleNormal),

                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Image(image: AssetImage('Assets/myrtle-falls-and-mount-rainier-michael-russell.jpg'), width: 150,),

                    ),

                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Выраженные особенности изображения:', textAlign: TextAlign.left,style: TextStyle(
                        fontSize: 16,
                        fontFamily: 'Arial',
                        fontWeight: FontWeight.bold,
                      )),
                    ),

                    Text('Выраженное различие почернения (оптической плотности) перпендикулярно сварному шву',
                        maxLines: 2,
                        textAlign: TextAlign.left,
                        style: _StyleNormal),


                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Сокращенная запись по ГОСТ 7512-82:',style: TextStyle(
                        fontSize: 16,
                        fontFamily: 'Arial',
                        fontWeight: FontWeight.bold,
                      )),
                    ),
                    Text('Скр150/Fd150',
                        textAlign: TextAlign.left,
                        style: _StyleNormal),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Описание на английском языке:',style: TextStyle(
                        fontSize: 16,
                        fontFamily: 'Arial',
                        fontWeight: FontWeight.bold,
                      )),
                    ),
                    Text('Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                        'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                        'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                        'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                        'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.',

                        textAlign: TextAlign.left,
                        style: _StyleNormal),





                  ],
                ),
              )
          ),
            SingleChildScrollView(

                child: Padding(
                  padding: EdgeInsets.fromLTRB(10, 0, 0, 0),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text('TEST', style: TextStyle(
                          fontSize: 20,
                          fontFamily: 'Arial',
                          fontWeight: FontWeight.bold,
                        )),
                      ),
                      Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text('TEST DESCRIPTION:', textAlign: TextAlign.left,style: TextStyle(
                          fontSize: 16,
                          fontFamily: 'Arial',
                          fontWeight: FontWeight.bold,
                        )),
                      ),


                      Text('LALALALALALALALALALALALLALA', style: _StyleNormal),

                      Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Image(image: AssetImage('Assets/myrtle-falls-and-mount-rainier-michael-russell.jpg'), width: 150,),

                      ),

                      Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text('Выраженные особенности изображения:', textAlign: TextAlign.left,style: TextStyle(
                          fontSize: 16,
                          fontFamily: 'Arial',
                          fontWeight: FontWeight.bold,
                        )),
                      ),

                      Text('Выраженное различие почернения (оптической плотности) перпендикулярно сварному шву',
                          maxLines: 2,
                          textAlign: TextAlign.left,
                          style: _StyleNormal),


                      Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text('Сокращенная запись по ГОСТ 7512-82:',style: TextStyle(
                          fontSize: 16,
                          fontFamily: 'Arial',
                          fontWeight: FontWeight.bold,
                        )),
                      ),
                      Text('Скр150/Fd150',
                          textAlign: TextAlign.left,
                          style: _StyleNormal),
                      Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text('Описание на английском языке:',style: TextStyle(
                          fontSize: 16,
                          fontFamily: 'Arial',
                          fontWeight: FontWeight.bold,
                        )),
                      ),
                      Text('Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                          'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                          'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                          'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.'
                          'Offset or Mismatch (Hi-Lo): A misalignment of the pieces to be welded. Radiographic Image: An abrupt change in film density across the width of the weld Image.',

                          textAlign: TextAlign.left,
                          style: _StyleNormal),

                    ],
                  ),
                )
            ),
            Text('Privet'),
            Text('Poka'),
            Text('Zdravstvuy'),
            Text('Hello'),
            Text('Ciao'),
          ],

      )
    )
    );
    /*return Scaffold(


       










    );*/
  }
}