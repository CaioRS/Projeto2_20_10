using System.Collections.Generic;
using System;

class Loja{
  //declaração de atributos
  private string nome;
  private string telefone;
  private string endereco;

  public List<Produto> lista = new List<Produto>();// iniciacao da lista de produtos, so existe loja se houver produtos, portanto , já é inicializada no começo o

  public Loja(string n , string t , string e){ // construtor cheio
    nome = n;
    telefone = t;
    endereco = e;
  }
  // gets
  public string GetNomeLoja(){
    return nome;
  }
  public string GetTelefoneLoja(){
    return telefone;
  }
  public string GetEnderecoLoja(){
    return endereco;
  }
  //cadastro de produtos na lista da loja
  public void CadastrarProdutos(){
    //criando os objeto Produtos
    Produto item00 = new Produto("00", "Arduino Uno  " , 20 , 89.50);
    Produto item01 = new Produto("01", "Arduino Mega " , 04 , 94.50);
    Produto item02 = new Produto("02", "Arduino Nano " , 06 , 71.30);
    Produto item03 = new Produto("03", "Tela LCD 16x2" , 08 , 39.30);
    Produto item04 = new Produto("04", "Tela LCD 20x4" , 04 , 43.60);
    Produto item05 = new Produto("05", "Servo SG 90g " , 10 , 37.90);
    Produto item06 = new Produto("06", "Servo SG 180g" , 12 , 43.50);
    Produto item07 = new Produto("07", "Sensor LDR   " , 22 , 15.00);
    Produto item08 = new Produto("08", "Sensor Prox. " , 08 , 09.00);
    Produto item09 = new Produto("09", "LED Col.Verme" , 90 , 01.00);
    Produto item10 = new Produto("10", "LED Col.Verde" , 90 , 01.00);
    Produto item11 = new Produto("11", "LED Col.Azul " , 90 , 01.00);
    // Adicionando para a lista
    lista.Add(item00);
    lista.Add(item01);
    lista.Add(item02);
    lista.Add(item03);
    lista.Add(item04);
    lista.Add(item05);
    lista.Add(item06);
    lista.Add(item07);
    lista.Add(item08);
    lista.Add(item09);
    lista.Add(item10);
    lista.Add(item11);        
  }

  //metodos
  public bool IncluirCarrinho(string i, int q){
    if(q > 0){ //apenas roda se a qtd selecionada for maior que 0
      for (int x=0;x<lista.Count;x++){ // roda a lista atras do mesmo ID do Produto
        if(lista[x].GetId() == i) { 
          if(lista[x].GetQtd() < q){ // verifica a quantidade que desaja vs estoque
            return false;
          }else return true;
        }
      }  
      return true;
    }
    else{
      return false;
    }
  }
  
  
  //public int AtualizarEstoque(string idlista, string idcarrinho , int qtdlista , int qtdcarrinho){
    
    
        
    
  //}  
}