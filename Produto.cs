class Produto{

// declacaracao dos atributos
  private string id;
  private string nome;
  private int qtd;
  private double preco;


  // construtor cheio para criacao da lista de produtos
  public Produto(string i , string n , int q , double p){
    id = i;
    nome = n;
    qtd = q;
    preco = p;
  }

  // set e gets para acessar atributos privates
  public void SetQtd(int q){
    if(q>=0){ // apenas permitir a alteração se a quantidade não for negativa
      qtd = q;
    }
  }

  public int GetQtd(){
    return qtd;
  }

  public string GetId(){
    return id;
  }

  public string GetNome(){
    return nome;
  }

  public double GetPreco(){
    return preco;
  }
}