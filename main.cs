using System;

class MainClass {
  public static void Main (string[] args) {

      // atualizacao 27/10


    //Cliente cliente = new Cliente();
    Agenda list = new Agenda(); 
    
    //string cond = "S";

    //while(cond == "S"){
      Console.Clear();
      Console.Write("INSIRA SEU NOME >> ");
      string name = Console.ReadLine();
      while(name == ""){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("O CAMPO DE NOME DEVE SER PREENCHIDO!\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("INSIRA SEU NOME >> ");
        name = Console.ReadLine();
      }
        

      Console.Write("\nINSIRA SUA IDADE >> ");
      int age = int.Parse(Console.ReadLine());
      while(age == 0 || age < 0){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("O CAMPO DE IDADE DEVE SER PREENCHIDO COM UMA IDADE VÁLIDA!\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("INSIRA SUA IDADE >> ");
        age = int.Parse(Console.ReadLine());
      }
        

      Console.Write("\nINSIRA SEU ENDEREÇO >> ");
      string ad = Console.ReadLine();
      while(ad == ""){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("O CAMPO DE ENDEREÇO DEVE SER PREENCHIDO!\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("INSIRA SEU ENDEREÇO >> ");
        ad = Console.ReadLine();
      }
        

      Console.Write("\nINSIRA SEU TELEFONE >> ");
      string cel = Console.ReadLine();
      if (cel == ""){
        cel = "Não Informado";
      }
        

      Console.Write("\nINSIRA SEU SEXO(Masculino ou Feminino) >> ");
      string gender = Console.ReadLine();
      if (gender == ""){
        gender = "Não Informado";
      }
        

      Cliente cliente = new Cliente(name , age, ad, cel, gender);

      list.listaCli.Add(cliente);
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nCadastro Efetuado com Sucesso, clique Enter para continuar!");
      Console.ForegroundColor = ConsoleColor.White;
      //Console.Write("S/N");
      //cond = Console.ReadLine();

    //}
    Console.WriteLine("\n*****Panorama Geral*****");

    for(int i = 0; i < list.listaCli.Count; i++){
      Console.WriteLine("Nome >> {0}\nIdade >> {1}\nEndereço >> {2}\nTelefone >> {3}\nSexo >> {4}", list.listaCli[i].getNome_Cli(), list.listaCli[i].getIdade(), list.listaCli[i].getEndereco(), list.listaCli[i].getTelefone(), list.listaCli[i].getSexo());
    }
    Console.ReadLine();
    Console.Clear();
    

    
  

    
    // Declaracoes de teste
    Loja teste = new Loja("teste","0000-0000","Cidade");
    Carrinho carrinho = new Carrinho(name);
    teste.CadastrarProdutos();
    int menu = 100;
    string continuar = "SIM";
    int exit=0;
    

    do{
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("LOJA DO ARDUINO..............................");
      Console.WriteLine("ESCOLHA UMA DAS OPÇÕES.......................");
      Console.WriteLine("   1 PARA ADICIONAR ITEM AO CARRINHO");
      Console.WriteLine("   2 PARA VISUALIZAR SEU CARRINHO");
      Console.WriteLine("   3 PARA ADICIONAR SALDO A CARTEIRA");
      Console.WriteLine("   4 PARA FINALIZAR COMPRA");
      Console.WriteLine("   5 PARA VISUALIZAR SUA CARTEIRA");
      Console.WriteLine("   6 PARA RETIRAR UM ITEM DO CARRINHO");
      Console.WriteLine("   0 PARA FECHAR O APLICATIVO");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("DIGITE SUA ESCOLHA:  ");

      menu = int.Parse(Console.ReadLine());

      if(menu!=0 && menu!=1 && menu!=2 && menu!=3 && menu !=4 && menu != 5 && menu!=1000 && menu != 6){
        Console.Clear();
        Console.WriteLine("OPÇÃO INVALIDA, ESCOLHA UMA ENTRE AS OPCOES");
        menu = 1000;
        Console.ReadLine();
      }

      if(menu==0){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("VOLTE SEMPRE {0}!!!", name);
        Console.ReadLine();
        return ;
      }

      if(menu==1){
        int rot = 0;
        do{
          Console.Clear();
          //Imprimir no console todos os itens da loja
          for (int i=0;i<teste.lista.Count;i++){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("COD:{0} - ITEM:{1} \nESTOQUE:{2} - PREÇO:R${3}\n----------------------------- ",teste.lista[i].GetId() , teste.lista[i].GetNome(), teste.lista[i].GetQtd(),teste.lista[i].GetPreco());
          }
          Console.ForegroundColor = ConsoleColor.White;
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

                if(teste.IncluirCarrinho(opcao,qtd)){
                            
                  carrinho.AtualizaQtd(opcao,qtd);
                  carrinho.MeuCarrinho[y].SetQtd(qtd); 
                  carrinho.VisualizarCarrinho(name);
                  exit = 1;
                  continuar = "N";
                  break;  
                }else{
                  Console.WriteLine("QUANTIDADE ESCOLHIDA NÃO PERMITIDA");      
                  Console.ReadLine();
                  exit = 1;
                  continuar = "N";
                  break;
                }
                
              }
            }   
          }

          if(exit==0){
            Console.Clear();
            Console.WriteLine("VOCE ESCOLHEU :    \n--------------------------------");
            Console.WriteLine("COD: {0} - ITEM: {1} \nESTOQUE:{2} - PREÇO: R${3}\n----------------------------- ",teste.lista[opcao_int].GetId() , teste.lista[opcao_int].GetNome(), teste.lista[opcao_int].GetQtd(),teste.lista[opcao_int].GetPreco());

            //usuario escolhe qtd
            Console.Write("ESCOLHA A QUANTIDADE QUE DESEJA:  ");
          
            int qtd = int.Parse(Console.ReadLine());

            if(teste.IncluirCarrinho(opcao,qtd)){
              
              Produto item = new Produto(teste.lista[opcao_int].GetId() , teste.lista[opcao_int].GetNome(), teste.lista[opcao_int].GetQtd(),teste.lista[opcao_int].GetPreco());

              carrinho.MeuCarrinho.Add(item);
              
              carrinho.AtualizaQtd(opcao,qtd);
              carrinho.MeuCarrinho[rot].SetQtd(qtd); 
              carrinho.VisualizarCarrinho(name);  
            }else{
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("QUANTIDADE ESCOLHIDA NÃO PERMITIDA,QUANTIDADE MAIOR QUE O ESTOQUE!");
              Console.ForegroundColor = ConsoleColor.White;      
              Console.ReadLine();
              break;
            }

            Console.WriteLine("DESEJA ESCOLHER OUTRO ITEM ? (S/N):  ");
            continuar = Console.ReadLine();

            while(continuar!="S" && continuar!="N"){
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("OPÇÃO INVALIDA, ESCOLHA UMA ENTRE AS OPCOES.");
              Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine("DESEJA ESCOLHER OUTRO ITEM ? (S/N):  ");
              continuar = Console.ReadLine();
            }
          }
          Console.Clear();
          rot++;
        }while(continuar == "S");
        Console.Clear();
      }

      if(menu==2){
        carrinho.VisualizarCarrinho(name);
        Console.ReadLine();
      }

      if(menu==3){
        Console.Clear();
        Console.Write("Digite o valor que deseja adicionar: ");
        double R = double.Parse(Console.ReadLine());
        cliente.SetCarteira(R);        
      }

      if(menu==4){
        Console.Clear();
        double valorcarrinho = carrinho.ValorCarrinho();
        double valorcarteira = cliente.getCarteira();
        if(valorcarteira>=valorcarrinho && carrinho.MeuCarrinho.Count != 0){
          for(int i=0 ; i<carrinho.MeuCarrinho.Count ; i++){
            for(int y=0; y<teste.lista.Count; y++){
              string idlista = teste.lista[y].GetId();
              string idcarrinho = carrinho.MeuCarrinho[i].GetId();
              if(idlista == idcarrinho){
                int qtdlista = teste.lista[y].GetQtd();
                int qtdcarrinho = carrinho.MeuCarrinho[i].GetQtd();
                qtdlista = qtdlista - qtdcarrinho;
                teste.lista[y].SetQtd(qtdlista);
              }
            }
          }
          Console.Clear();
          carrinho.VisualizarCarrinho(name);
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("COMPRA FEITA COM SUCESSO, NOVO SALDO NA CARTEIRA: R$ {0}",valorcarteira-valorcarrinho);
          valorcarteira = valorcarteira - valorcarrinho;
          cliente.AtualizaCarteira(valorcarteira);
          Console.ForegroundColor = ConsoleColor.White;
          Console.ReadLine();
          carrinho.MeuCarrinho.Clear();

        }else if(carrinho.MeuCarrinho.Count == 0){
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("CARRINHO VAZIO! ADICIONE ALGO PARA FINALIZAR A COMPRA.");
          Console.ForegroundColor = ConsoleColor.White;
          Console.ReadLine();

        }else{
          Console.Clear();
          carrinho.VisualizarCarrinho(name);
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("SALDO INSUFICIENTE EM CARTEIRA, FAVOR ADICIONAR SALDO.");
          Console.ForegroundColor = ConsoleColor.White;
          Console.ReadLine();
        }
      }

      if(menu==5){
        Console.Clear();
        Console.WriteLine("Sua carteira está com um saldo atual de R${0}", cliente.getCarteira());
        Console.ReadLine();
      }

      if(menu==6){
        Console.Clear();
        if(carrinho.MeuCarrinho.Count != 0){
          carrinho.VisualizarCarrinho(name);
          Console.Write("\nInsira o código do produto a ser removido  do carrinho >> ");
          string cod = Console.ReadLine();
          carrinho.RemoverItem(cod);
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Item {0} removido com Sucesso!", cod);
          Console.ForegroundColor = ConsoleColor.White;
          Console.ReadLine();

        }else{
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Carrinho vazio! Não há itens para remover.");
          Console.ForegroundColor = ConsoleColor.White;
          Console.ReadLine();   
        }
        

      }

    }while (menu!=0);
    
  }
}