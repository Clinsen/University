% Пункт 1: Інформація про функцію hardlims
name = hardlims('name');         % Повна назва функції
inrange = hardlims('active');    % Діапазон входу
outrange = hardlims('output');   % Діапазон виходу

disp('Інформація про функцію hardlims:');
disp(['Повна назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -5:0.1:5;
a = hardlims(n);
da = dhardlims(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації hardlims');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної hardlims');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-0.7; 0.1; 0.8];
A = hardlims(N);          % Вектор виходу функції активації
dA_dN = dhardlims(N, A);  % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');
