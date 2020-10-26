using System;
using System.Collections.Generic;

class Carrinho{
  private string NomeCliente;
  public List<Produto> MeuCarrinho = new List<Produto>();

  public Carrinho(string n){
    NomeCliente = n;
  }

  public void VisualizarCarrinho(string n){
    Console.Clear();
    Console.WriteLine("Carrinho do(a): {0}\n\n----------------------------" ,n);
    double valor=0;
    for (int x=0;x<MeuCarrinho.Count;x++){
      Console.WriteLine("COD:{0} - ITEM:{1} \nQTD:{2} - PREÇO:R${3}\n----------------------------- ",MeuCarrinho[x].GetId() , MeuCarrinho[x].GetNome(), MeuCarrinho[x].GetQtd(), MeuCarrinho[x].GetPreco() );

      valor = valor + (MeuCarrinho[x].GetPreco()*MeuCarrinho[x].GetQtd());
    }
    Console.WriteLine("SUB-TOTAL DO CARRINHO: R$ {0}",valor);
  }
  
  public double ValorCarrinho(){
    double valor=0;
    for (int x=0;x<MeuCarrinho.Count;x++){
      Console.WriteLine("COD:{0} - ITEM:{1} \nQTD:{2} - PREÇO:R${3}\n----------------------------- ",MeuCarrinho[x].GetId() , MeuCarrinho[x].GetNome(), MeuCarrinho[x].GetQtd(), MeuCarrinho[x].GetPreco() );

      valor = valor + (MeuCarrinho[x].GetPreco()*MeuCarrinho[x].GetQtd());
    }
    return valor;
  }


  public void AtualizaQtd(string cod, int q){
    for(int x=0;x<MeuCarrinho.Count;x++){
      if(cod == MeuCarrinho[x].GetId()){
        MeuCarrinho[x].SetQtd(q);
      }
    }
  }

  public void RemoverItem(string id){
    for(int i=0 ; i<MeuCarrinho.Count; i++){
        if(id == MeuCarrinho[i].GetId()){
           MeuCarrinho.RemoveAt(i);
        } 
    }
}








}