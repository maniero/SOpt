ArrayList<Elemento> e = new ArrayList(); //Elemento e uma classe
for (int i = 0; i<10;i++) {
   e.add(new Elemento());
   e.get(i).texto = "teste";
   e.get(i).texto2 =  "algo";
   e.get(i).numero = i;
}
e = new ArrayList();

ArrayList<Elemento> x = new ArrayList<>();
x.add(new Elemento())
ArrayList<Elemento> y = x;
x = new ArrayList<>(); //y permanece com o elemento, afinal x passou ter uma nova instância

ArrayList<Elemento> x = new ArrayList<>();
x.add(new Elemento())
ArrayList<Elemento> y = x;
x.clear(); //y não tem mais nada também

//https://pt.stackoverflow.com/q/118847/101
