% Пункт 1: Інформація про функцію satlins
name = 'satlins';               % Назва функції активації
inrange = [-1, 1];              % Діапазон входу
outrange = [-1, 1];             % Діапазон виходу

disp('Інформація про функцію satlins:');
disp(['Назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -1.5:0.01:1.5;
a = satlins(n);
da = dsatlins(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації satlins');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dsatlins');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-0.7; 0.1; 1.2];
A = satlins(N);          % Вектор виходу функції активації
dA_dN = dsatlins(N);      % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');
