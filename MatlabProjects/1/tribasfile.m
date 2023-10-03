% Пункт 1: Інформація про функцію tribas
name = 'tribas';                % Назва функції активації
inrange = [-1, 1];              % Діапазон входу
outrange = [0, 1];              % Діапазон виходу

disp('Інформація про функцію tribas:');
disp(['Назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -1.5:0.01:1.5;
a = tribas(n);
da = dtribas(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації tribas');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dtribas');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-0.7; 0.1; 1.2];
A = tribas(N);          % Вектор виходу функції активації
dA_dN = dtribas(N);      % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');
