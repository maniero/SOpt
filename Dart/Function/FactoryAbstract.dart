abstract class WidgetService {
    WidgetService _cached; 
    factory WidgetService(String type) {
        switch (type) {
            case 'a': return new ConcreteWidgetServiceA();
            case 'b': return new ConcreteWidgetServiceB();
            default: throw new ArgumentError("precisa de um nome válido");
        }
    }
    Widget getWidget();
    void saveWidget(Widget widget);
}

class ConcreteWidgetServiceA extends BaseWidgetService implements WidgetService {
    WidgetService();
    Widget getWidget() {
        // code to get widget here
    }
    void saveWidget(Widget widget) {
        // code to save widget here
    }
}

class ConcreteWidgetServiceB extends BaseWidgetService implements WidgetService {
    WidgetService();
    Widget getWidget() {
        // code to get widget here
    }
    void saveWidget(Widget widget) {
        // code to save widget here
    }
}

//https://pt.stackoverflow.com/q/434498/101
