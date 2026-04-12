using AbstractFactory.Factory;
using AbstractFactory.Factory.interfaces;

IGUIFactory factory;

factory = new WindowsFactory();
factory.createbutton().Paint();
factory.createCheckBox().Paint();

factory = new MacFactory();
factory.createbutton().Paint();
factory.createCheckBox().Paint();