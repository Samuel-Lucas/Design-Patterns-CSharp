using State.Class;
using State.States;

var context = new Context();

// state A executed
context.State = new StateA();
context.Request();

// state B executed
context.Request();

// state A is executed again
context.Request();