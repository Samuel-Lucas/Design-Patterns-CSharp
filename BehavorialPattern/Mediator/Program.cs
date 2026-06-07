using Mediator.Entity;
using Mediator.Interfaces;
using Mediator.Mediator.ConcreteMediator;

// create chatroom
IChatRoom chatRoom = new ChatRoom();

// create users
User user1 = new ChatUser(chatRoom);
User user2 = new ChatUser(chatRoom);
User user3 = new ChatUser(chatRoom);

// register users
chatRoom.Register(user1);
chatRoom.Register(user2);
chatRoom.Register(user3);

// send messages
user1.Send("Hello world !");
user2.Send("Hi there");