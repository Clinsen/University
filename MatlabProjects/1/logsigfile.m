% Пункт 1: Інформація про функцію logsig
name = 'logsig';                 % Назва функції активації
inrange = [-inf, inf];           % Діапазон входу
outrange = [0, 1];               % Діапазон виходу

disp('Інформація про функцію logsig:');
disp(['Назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -10:0.1:10;
a = logsig(n);
da = dlogsig(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації logsig');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dlogsig');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-2; 0; 2];
A = logsig(N);          % Вектор виходу функції активації
dA_dN = dlogsig(N);      % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');
