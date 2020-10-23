using System;
using System.Collections.Generic;

class Cliente{

  //atributos e seus getters e setters
  private string Nome_Cli;
  public void setNome(string n){
    Nome_Cli = n;
  }
  public string getNome_Cli(){
    return Nome_Cli;
  }

  private int Idade;
  public void setIdade(int i){
    Idade = i;
  }
  public int getIdade(){
    return Idade;
  }

  private string Endereco;
  public void setEndereco(string e){
    Endereco = e;
  }
  public string getEndereco(){
    return Endereco;
  }

  private string Telefone;
  public void setTelefone(string t){
    Telefone = t;
  } 
  public string getTelefone(){
    return Telefone;
  }

  private string Sexo;
  public void setSexo(string s){
    Sexo = s;
  }
  public string getSexo(){
    return Sexo;
  }

  private double Carteira;
  public void SetCarteira(double R){
    if (R<=200.00){
      Carteira += R;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Valor incluido com sucesso !");
      Console.WriteLine("Novo saldo na Carteira Virtual : R$ {0}",Carteira);
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();
    }else{
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Valor Indisponível de inclusão.... Valor Limite R$ 200.00");
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();
    }

  }

  public void AtualizaCarteira(double R){
    Carteira = R;
  }

  public double getCarteira(){
    return Carteira;
  }


  public Cliente(string n, int i, string e, string t, string s){
    Nome_Cli = n;
    Idade = i;
    Endereco = e;
    Telefone = t;
    Sexo = s;
    Carteira = 0;
  }

  /*
  public List<string> ListaUsu;

  public Cliente(){
    ListaUsu = new List<string>();
  }

  //cadastrando o cliente, n consegui fazer em outra classe dava erro de overload.
  public void CadastrarCliente(){
    Console.Write("Nome >> ");
    Nome_Cli = Console.ReadLine();
    ListaUsu.Add(Nome_Cli);

    Console.Write("Idade >> ");
    Idade = Console.ReadLine();
    ListaUsu.Add(Idade); 
    
    Console.Write("Endereço >> ");
    Endereco = Console.ReadLine();
    ListaUsu.Add(Endereco);

    Console.Write("Telefone >> ");
    Telefone = Console.ReadLine();
    ListaUsu.Add(Telefone);
    
    for (int i = 0; i < ListaUsu.Count; i++){
      Console.WriteLine(ListaUsu[i]);
    }
    Console.ReadLine();
    */
  }
 
