using System;

class MainClass {
  public static void Main (string[] args) {
    
    // Declaracoes de teste
    Loja teste = new Loja("teste","0000-0000","Cidade");
    Carrinho carrinho = new Carrinho("Caio");
    teste.CadastrarProdutos();
    int menu = 100;
    string continuar = "SIM";
    int exit=0;

    do{
      Console.Clear();
      Console.WriteLine("LOJA DO ARDUINO..............................");
      Console.WriteLine("ESCOLHA UMA DAS OPÇÕES.......................");
      Console.WriteLine("   1 PARA ADICIONAR ITEM AO CARRINHO");
      Console.WriteLine("   2 PARA VISUALIZAR SEU CARRINHO");
      Console.WriteLine("   3 PARA FINALIZAR A COMPRA");
      Console.WriteLine("   0 PARA FECHAR O APLICATIVO");
      Console.Write("DIGITE SUA ESCOLHA:  ");

      menu = int.Parse(Console.ReadLine());

      if(menu!=0 && menu!=1 && menu!=2 && menu!=3 && menu!=1000 ){
        Console.Clear();
        Console.WriteLine("OPÇÃO INVALIDA, ESCOLHA UMA ENTRE AS OPCOES");
        menu = 1000;
        Console.ReadLine();
      }

      if(menu==0){
        Console.Clear();
        Console.WriteLine("VOLTE SEMPRE !!!");
        Console.ReadLine();
        return ;
      }

      if(menu==1){
        do{
          Console.Clear();
          //Imprimir no console todos os itens da loja
          for (int i=0;i<teste.lista.Count;i++){
            Console.WriteLine("COD:{0} - ITEM:{1} \nESTOQUE:{2} - PREÇO:R${3}\n----------------------------- ",teste.lista[i].GetId() , teste.lista[i].GetNome(), teste.lista[i].GetQtd(),teste.lista[i].GetPreco());
          }
          Console.Write("DIGITE O COD DO PRODUTO:  "); 
          //usuario escolhe o produto
          string opcao = Console.ReadLine();
          int opcao_int = int.Parse(opcao);

          if(opcao_int<0 || opcao_int>12){
            Console.Clear();
            Console.Write("OPÇÃO INVALIDA, ESCOLHA UMA ENTRE AS OPCOES");
            Console.ReadLine();
            break;
          }

          
          //TESTE PARA TENTAR INCLUIR 2VEZES O MESMO ITEM.... N MEXER
          for(int y=0 ; y< carrinho.MeuCarrinho.Count  ; y++){
            if(carrinho.MeuCarrinho[y].GetId() == opcao){
              Console.Clear();
              Console.WriteLine("ESTE ITEM JÁ ESTA NO CARRINHO, ATUALIAR QUANTIDADE? (S/N)");
              continuar = Console.ReadLine();
              while(continuar!="S" && continuar!="N"){
                Console.Clear();
                Console.WriteLine("OPÇÃO INVALIDA, ESCOLHA UMA ENTRE AS OPCOES");
                Console.WriteLine("DESEJA ATUALIAR QUANTIDADE ? (S/N):  ");
                continuar = Console.ReadLine();
              }
              if(continuar=="N") {
                exit = 1;
                continuar = "N";
                break;
              }
              if(continuar=="S"){
                Console.Clear(); 
                Console.Write("ESCOLHA A QUANTIDADE QUE DESEJA:  ");
                int qtd = int.Parse(Console.ReadLine());

                if(true){
                  Console.Clear(); 
                  carrinho.AtualizaQtd(opcao,qtd);
                  carrinho.VisualizarCarrinho("Caio");
                  Console.ReadLine();
                  continuar = "N";
                  exit = 1;
                  break;
                }
                else{
                  Console.Clear(); 
                  Console.WriteLine("QUANTIDADE ESCOLHIDA NÃO PERMITIDA");
                  Console.ReadLine();
                  exit = 1;
                  continuar = "N";
                  menu=1000;
                  break;
                }
              }
            }   
          }

          if(exit==0){
            Console.Clear();
            Console.WriteLine("VOCE ESCOLHEU :    \n--------------------------------");
            Console.WriteLine("COD:{0} - ITEM:{1} \nESTOQUE:{2} - PREÇO:R${3}\n----------------------------- ",teste.lista[opcao_int].GetId() , teste.lista[opcao_int].GetNome(), teste.lista[opcao_int].GetQtd(),teste.lista[opcao_int].GetPreco());

            //usuario escolhe qtd
            Console.Write("ESCOLHA A QUANTIDADE QUE DESEJA:  ");
          
            int qtd = int.Parse(Console.ReadLine());

            if(teste.IncluirCarrinho(opcao,qtd)){
              carrinho.MeuCarrinho.Add(teste.lista[opcao_int]);
              carrinho.AtualizaQtd(opcao,qtd); 
              carrinho.VisualizarCarrinho("Caio");  
            }else{
              Console.WriteLine("QUANTIDADE ESCOLHIDA NÃO PERMITIDA");      
              Console.ReadLine();
              break;
            }

            Console.WriteLine("DESEJA ESCOLHER OUTRO ITEM ? (S/N):  ");
            continuar = Console.ReadLine();

            while(continuar!="S" && continuar!="N"){
              Console.Clear();
              Console.WriteLine("OPÇÃO INVALIDA, ESCOLHA UMA ENTRE AS OPCOES");
              Console.WriteLine("DESEJA ESCOLHER OUTRO ITEM ? (S/N):  ");
              continuar = Console.ReadLine();
            }
          }
          Console.Clear();
        }while(continuar == "S");
        Console.Clear();
      }

      if(menu==2){
        carrinho.VisualizarCarrinho("Caio");
        Console.ReadLine();
      }

    }while (menu!=0);
  }
}