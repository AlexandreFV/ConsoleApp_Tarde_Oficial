// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Eranka;

Produto p1 = new Produto(1,"Mouse xing ling", 10.90M);
Produto p2 = new Produto(2,"Teclado multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,
    "15906304",
    "Mario Miziara",
    91,
    "Sobral",
    "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "991340447",e1);
Cliente c2 = new Cliente(2, "Victoria", "991340447",e1);
Cliente c3 = new Cliente(3, "Rafael", "991340447", e1);
Cliente c4 = new Cliente(4, "Lucas", "9913409876" ,e1  );
Cliente c5 = new Cliente(5, "Eduardo", "991340447", e1);


Console.WriteLine(c1.getEndereco().EnderecoCompleto()  );
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto() );
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "POrtal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();
car.Cor = "Vermelho";
car.quantRodas = 4;
car.quantAssentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.Cor = "Azul";
bicicleta.quantRodas = 2;
bicicleta.quantAssentos = 1;
car.TemMotor = false;

Aviao aero = new Aviao();
aero.Cor = "Branca";
aero.quantAssentos = 200;
aero.quantRodas = 3;
car.TemMotor = true;



