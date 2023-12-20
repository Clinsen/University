%Мережа Кохонена
clc;
%z = network;
y1 = 0 + rand(1,100);
x1 = 9 + rand(1,100);
%plot(x1,y1,'ob');

y2 =  0 + rand(1,100);
x2 = -9 + rand(1,100);
%plot(x2,y2,'or');

y3 = 9 + rand(1,100);
x3 = 0 + rand(1,100);

y4 = -9 + rand(1,100);
x4 =  0 + rand(1,100);

figure(1)
hold on
plot(x3,y3,'og')
plot(x4,y4,'oy')
plot(x1,y1,'ob')
plot(x2,y2,'or')
grid on
hold off;
x(1:100)=x1;
x(101:200)=x2;
x(201:300)=x3;
x(301:400)=x4;

y(1:100)=y1;
y(101:200)=y2;
y(201:300)=y3;
y(301:400)=y4;
%z(1,1:120)=x;
%z(2,1:120)=y;

z = [x; y]; 

net = newsom(z,[2 2]);
net = train(net,z);
sizeNet = size(z);
a = sim(net,z);

