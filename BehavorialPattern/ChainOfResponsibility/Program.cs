using ChainOfResponsibility.Handlers;

Handler handler = new ConcreteHandler();
Handler handler2 = new ConcreteHandler2();
Handler handler3 = new ConcreteHandler3();

handler.SetSucessor(handler2);
handler2.SetSucessor(handler3);

// send requests to chain
int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20};

foreach (int request in requests)
{
    handler.HandleRequest(request);
}