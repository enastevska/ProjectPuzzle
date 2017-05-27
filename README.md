# ProjectPuzzle
Проектна задача по Визуелно програмирање

PUZZLE


Апликацијата која одбравме да ја имплементираме за изработка на овој проект е едноставна верзија на играта Сложувалка – Puzzle. Главната идеја се состои од тоа да му се даде слобода на корисникот да избере своја слика од сопствениот работен директориум, и по избирањето започнува играта или решавањето на сложувалката. При самото решавање од десната страна како помош стои  решената слика, која би го водела играчот до каде е со неговото решение.

Чекор 1:
Играта започнува само при клик на копчето Choose an image. Со клик на ова копче се отвара дијалог за избор на слика по желба на играчот. Играчот избира слика од било кој директориум на сопствениот уред и одбраната слика се префрла на двете паноа – едното за решавање на сложувалката и второто како пример за решена сложувалка.

Чекор 2:
Следно откако сликата е избрана, потребно е да се избере едно од трите копчиња: Level 1, Level 2 или Level 3. Со ова избирање всушност играчот го одбира нивото на тежина на играта, односно број на парчиња сложувалки на кои ќе биде поделена сликата. Level 1 ја дели сликата на 4 парчиња, Level 2 на 16, а Level 3 на 25 парчиња. Притоа за една игра може да биде избран само еден Level.

Чекор 3:
Со овој чекор започнува решавањето на сложувалката. Играчот треба да селектира две парчиња и со тоа ќе се изврши замена на местата на тие две парчиња. Притоа, играчот не е ограничен со број на замени кои мора да ги изврши за да ја реши сложувалката.

Чекор 4:
Играчот во било кое време може да ја прекине започнатата игра со клик на копчето Start a new game. Со овој клик се отвара нов дијалог кој го препрашува играчот дали е сигурен дека сака да ја напушти играта.
	Решение на проблемот
Најпрво се решава проблемот на скалирање на сликата за да биде еднаква големина како панелите. За тоа користиме Bitmap која ја претставува избрана слика во посакуваната големина на панелот.
Главниот проблем е поделбата на избраната слика на еднакви делчиња. За ова користиме две структури: низа од PictureBox и низа од Image објекти. Низите се алоцираат со бројот на парчиња од кои сакаме да се состои сложувалката. Сликата се сече на бараниот број парчиња и со овие парчиња се полни низата од Image објекти. Притоа секој од објектот PictureBox соодветно го алоцираме, му доделуваме висина, ширина и позицијата на која ќе стои како засебна слика (парче сложувалка).
Откако на секој објект ќе му ги придружиме овие особини, се додава на панелот, со што се формира слика на исечени парчиња од избраната слика. Дополнително, со помош на функцијата shuffle овие парчиња се изместуваат од почетниот распоред на исечената слика.


	Опис на функции

1.	private void CutPicture(Image image, Image[] images, int index, int numberRows, int numberColumns, int pieceX, int pieceY)

Со оваа функција избраната слика која сакаме да ја решаваме како сложувалка, соодветно ја делиме на слики – парчиња сложувалки. 
Објект од низата images се алоцира со битмапа со големина која ние ја задаваме, во конкретниов случај поделеноста на сликата според висина и ширина за секое парче да биде еднакво со останатите. По ова, со помош на библиотеката Graphics, оваа сликичка ќе биде соодветно исцртана. Бидејќи сакаме сите мали сликички да бидат исцртани соодветно, оваа функција се повикува во for циклус.

2.	private void shuffle(ref int [] array)

Со помош на функцијата shuffle исецканите сликички ќе се разместат од првобитната положба. Со Random избраната вредност, секој индекс од должината на низата објекти ќе биде соодветно позициски заменет со таа вредност.

3.	public void PuzzleClick(object sender, EventArgs e)

Претставува сопствено изработен Click Event за сложувалката. Со оваа функција, потребно е да бидат селектирани два PictureBox-a при што потоа ќе следи нивна локациска замена.  Соодветно се опфатени случаевите доколку е избран само еден PictureBox, да не може да биде извршена замена.


	Активности при клик на копче
1.	private void btnLevel2_Click(object sender, EventArgs e)

Бидејќи бирањето на копче Level,  работи само при почеток на нова игра, најпрво се проверува дали на панелот веќе има избрано слика. Доколку има, таа се пребришува. Доколку нема, се алоцираат двете низи од PictureBox и од Image на 16 објекти, што би означувало 16 парчиња на кои ќе биде поделена сликата. Потоа pieceX и pieceY, кои ги означуваат димензиите на исечените слики се доделуваат со вредности. Наредно, секој PictureBox од низата се алоцира со нов објект и му се доделуваат соодветните висина и ширина, како и подоцна неговата локација при додавање на целовкупниот панел. Со повикувањето на функцијата CutPicture истото се прави и за низата од Image.  Низата од integer-и tmpArray е потребна при повик на функцијата shuffle, за да се измешаат индексите на локациите на сликичките.




Изработиле:
Елена Настевска 151044
Марина Неделчева 151039
      




