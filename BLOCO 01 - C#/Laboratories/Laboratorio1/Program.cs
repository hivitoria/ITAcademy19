// Laboratório 01- Conhecendo C#.

//==========================================
// 01. Trabalhando com tipos: valor fundamentais byte, int e long.
//==========================================

// Exemplo com byte.
byte b;
b = byte.MaxValue;
Console.WriteLine("Valor maximo de byte: " + b);

// Exemplo com int.
int i;
i = int.MaxValue;
Console.WriteLine("Valor maximo de int: " + i);

// Exemplo com long.
long l;
l = long.MaxValue;
Console.WriteLine("Valor maximo de long: " + l);

//==========================================
// 02. Trabalhando com strings.
//==========================================

string strPrimeira = "Alo";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString();

Console.WriteLine(strQuarta);
Console.WriteLine(strTerceira.Substring(0, 5));

//==========================================
// 03. Trabalhando com objetos do Framework.
//==========================================

DateTime dt = new DateTime(2015, 04, 23);

string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);

//==========================================
// 04. EXERCÍCIOS.
//==========================================

// 01. Além de tipos inteiros, C# também suporta float, double, e decimal 
// o qual garante uma boa precisão para trabalhos com valores monetários.
// Escreva algum código para testar variáveis destes novos tipos e mostrar o 
// resultado na tela do console.

// Exemplo com float.
float f;
        f = float.MaxValue;
        Console.WriteLine("Valor máximo de float: " + f);

// Exemplo com double.
     double d;
        d = double.MaxValue;
        Console.WriteLine("Valor máximo de double: " + d);

// Exemplo com decimal.
     decimal dc;
        dc = decimal.MaxValue;
        Console.WriteLine("Valor máximo de decimal: " + dc);

//==========================================

// 02. Busque na documentação da biblioteca de classes do .Net novas operações 
// da classe String. Faça experiências e mostre os resultados na tela.

// Create a string from a character array.
char[] chars = {'w', 'o', 'r', 'd'};

string string1 = new string(chars);
Console.WriteLine(string1);

// Create a string that consists of a character repeated 20 times.
string string2 = new string('c', 20);
Console.WriteLine(string2);

//==========================================

// 03. Busque na documentação da biblioteca de classe do .Net novas operações
// da classe DateTime. Faça experiências e mostre os resultados na tela.

DateTime data1 = DateTime.Now;
DateTime data2 = DateTime.UtcNow;
DateTime data3 = DateTime.Today;

Console.WriteLine(data1);
Console.WriteLine(data2);
Console.WriteLine(data3);

//==========================================

// 04. Converter dados em C# se dá de forma implícita ou explícita. Digite o
// seguinte exemplo e note que a conversão para um tipo "maior" é feita de
// forma implícita e, para um tipo "menor" de forma explícita.

int i2 = 10;
float f2 = 0;

f2 = i2; //conversão implícita, sem perda de dados.
System.Console.WriteLine(f);

f2 = 0.5F;
i2 = (int) f2; //conversão explícita, com perda de dados.
System.Console.WriteLine(i);

//==========================================

// 05. Além das conversões realizadas pela linguagem C#, podemos utilizar um mecanismo
// fornecido pelo próprio Framework, que é independente da linguagem utilizada. Este
// mecanismo é a classe System.Convert.

string stringInteiro = "123456789";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);

Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

// Adicione agora as seguintes linhas ao seu programa:
// string stringInteiroGrande = "999999999999999999999999999999999999999999999";
// int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);

//==========================================

// 06. Escreva um programa para testar o método TryParse.

string stringInteiro2 = "123456789";
int valorStringInteiro2;
bool conversao1 = Int32.TryParse(stringInteiro2, out valorStringInteiro2);
Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro2);

string sInteiroGrande = "999999999999999999999999999999999999999999999";
int valorInteiroGrande;
bool conversao2 = Int32.TryParse(sInteiroGrande, out valorInteiroGrande);
Console.WriteLine(" = Conversão efetuada:" + conversao2 + " Valor: " + valorInteiroGrande);

string stringLetras = "abc";
double valorLetras;
bool conversao3 = Double.TryParse(stringLetras, out valorLetras);
Console.WriteLine(" = Conversão efetuada:" + conversao3 + " Valor: " + valorLetras);

//==========================================

// 07. Devemos ter muito cuidado com os métodos de conversão de valores, pois
// arredondamentos são executados de formas diferentes. Verifique o comportamento
// do seguinte trecho de código.

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);

Console.WriteLine(" = Conversão explicita = " + valorInteiro1);
Console.WriteLine(" = Conversão método Convert = " + valorInteiro2);

//==========================================

// 08. O comando de saída em console tem uma sintaxe específica para a exibição
// de valores de várias variáveis. Teste o trecho abaixo. Explique como o mesmo funciona.

int x = 10;
double y = 3.4;

Console.WriteLine("{0} {1}",x,y);
Console.WriteLine($"{x} {y}");

//==========================================