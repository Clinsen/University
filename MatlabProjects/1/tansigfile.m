% Пункт 1: Інформація про функцію tansig
name = 'tansig';                % Назва функції активації
inrange = [-inf, inf];           % Діапазон входу
outrange = [-1, 1];              % Діапазон виходу

disp('Інформація про функцію tansig:');
disp(['Назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -10:0.1:10;
a = tansig(n);
da = dtansig(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації tansig');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dtansig');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-2; 0; 2];
A = tansig(N);          % Вектор виходу функції активації
dA_dN = dtansig(N);      % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');