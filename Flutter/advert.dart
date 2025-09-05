import 'package:flutter/material.dart';
import 'package:atlas/defects.dart';
import 'package:url_launcher/url_launcher.dart';
import 'package:atlas/about.dart';
import 'package:atlas/homePage.dart';

final Uri _url = Uri.parse('https://ask-roentgen.ru/');
final Uri _url2 = Uri.parse('https://ask-roentgen.ru/contacts');

Future<void> _launchUrl() async {
  if (!await launchUrl(_url)) {
    throw Exception('Could not launch $_url');
  }
}

Future<void> _launchUrl2() async {
  if (!await launchUrl(_url2)) {
    throw Exception('Could not launch $_url2');
  }
}

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

class Advert extends StatelessWidget{
  const Advert({super.key});

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
                const PopupMenuItem(
                  value: 3,
                  child: Row(
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
                      child: Text('Все приведенные изображения получены на радиографической пленке AGFA STRUCTURIX.', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('ООО «АСК-РЕНТГЕН» предлагает расходные материалы и '
                          'оборудование для проведения рентгеновского неразрушающего контроля:', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                    ),
                    Text('•	Промышленная рентгеновская пленка AGFA Structurix.', style: _StyleNormal, maxLines: 3),
                    Text('•	Химические реактивы AGFA для фотообработки пленки.', style: _StyleNormal, maxLines: 3),
                    Text('•	Усиливающие экраны.', style: _StyleNormal, maxLines: 3),
                    Text('•	Проявочные машины и принадлежности.', style: _StyleNormal, maxLines: 3),
                    Text('•	Сушильная техника.', style: _StyleNormal, maxLines: 3),
                    Text('•	Переносные рентгеновские аппараты постоянного потенциала ERESCO MF4.', style: _StyleNormal, maxLines: 3),
                    Text('•	Стационарные рентгеновские аппараты постоянного потенциала ISOVOLT Titan.', style: _StyleNormal, maxLines: 3),

                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Row(
                        children: [
                          Expanded(child: Text('Подробнее о нашей продукции на сайте: ', style: _StyleBold, maxLines: 3,),),
                          TextButton(onPressed: _launchUrl, child: Text('www.ask-roentgen.ru', style: _StyleBold)),
                        ],
                      ),

                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Тел. для связи: (812) 748-38-18', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('E-mail: auto@ask-roentgen.ru ', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text('Для отправки нам сообщения воспользуйтесь формой обратной связи у нас на сайте: ', style: _StyleBold),
                    ),
                    Padding(
                      padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: TextButton(onPressed: _launchUrl2, child: Text('Обратная связь', style: _StyleBold)),

                    )






                  ],
                ),
              )
          ),
        )
    );
  }
}