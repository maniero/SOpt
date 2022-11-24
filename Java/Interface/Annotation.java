import java.lang.annotation.*;  
import java.lang.reflect.*;  

//criando a anotação
@Retention(RetentionPolicy.RUNTIME) //são anotações usadas para criar anotações
@Target(ElementType.METHOD) //só permite usar em métodos
@interface MyAnnotation { //note o @
    int value();  
}  

//usando-a
class Hello {  
    @MyAnnotation(value = 10)  
    public void sayHello() {
        System.out.println("hello annotation");
    }
}  

//pegando dados dela
class TestCustomAnnotation1 {
    public static void main(String args[]) throws Exception {
        Hello h = new Hello();
        Method m = h.getClass().getMethod("sayHello");
        MyAnnotation manno = m.getAnnotation(MyAnnotation.class);
        System.out.println("value is: " + manno.value());
    }
}

//https://pt.stackoverflow.com/q/571176/101
