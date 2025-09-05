import 'package:flutter/material.dart';
import 'package:atlas/defects.dart';
import 'package:url_launcher/url_launcher.dart';
import 'package:atlas/advert.dart';
import 'package:atlas/homePage.dart';

final Uri _url = Uri.parse('https://ask-roentgen.ru/contacts/');

const _StyleNormal = TextStyle(
  fontSize: 14,
  fontFamily: 'Arial',
  fontWeight: FontWeight.normal,
);
const _StyleBold = TextStyle(
  fontSize: 14,
  fontFamily: 'Arial',
  fontWeight: FontWeight.bold,
);

Future<void> _launchUrl() async {
  if (!await launchUrl(_url)) {
    throw Exception('Could not launch $_url');
  }
}

class About extends StatelessWidget{
  const About({super.key});

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
                const PopupMenuItem(
                  value: 2,
                  child: Row(
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
          body: const SingleChildScrollView(
              child: Padding(
                padding: EdgeInsets.fromLTRB(10, 0, 0, 0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('О программе', style: TextStyle(
                        fontSize: 14,
                        fontFamily: 'Arial',
                        fontWeight: FontWeight.bold,
                      )),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('В данном приложении приводится альбом репродукций радиографических снимков сварных соединений, а также их расшифровка и условная сокращенная запись дефектов по ГОСТ 7512-82 в русском и латинском алфавите и сокращение по ОСТ Газпром 2-2.4-083-2006.'
                      'Схемы поперечных сечений сварных соединений при расшифровке не рассматривались.'
                        'Классификация дефектов соответствует требованиям ГОСТ 23055-78.'
                        'При расшифровке за размеры несплошностей приняты размеры их изображений на репродукциях по ГОСТ 23055-78, п.2.',
                          maxLines: 64,
                          textAlign: TextAlign.left,
                          style: _StyleNormal),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Row(
                        children: [
                          Text('Номер версии: ', style: _StyleBold),
                          Text('2.0',
                              maxLines: 2,
                              textAlign: TextAlign.left,
                              style: _StyleNormal),
                        ],
                      ),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Владелец: ', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('ООО «АСК-РЕНТГЕН» (Россия, Санкт-Петербург). Все материалы, использованные в '
                          'данном приложении, являются собственностью ООО «АСК-РЕНТГЕН». Коммерческое '
                          'использование данной программы без разрешения ООО «АСК-РЕНТГЕН» не допускается.',
                          maxLines: 64,
                          textAlign: TextAlign.left,
                          style: _StyleNormal),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('«Столкнулись с проблемой? Хотите высказать пожелания или замечания? Напишите нам» ', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: TextButton(onPressed: _launchUrl, child: Text('Обратная связь', style: _StyleBold)),

                    )


                  ],
                ),
              )
          ),
        )
    );
  }
}

