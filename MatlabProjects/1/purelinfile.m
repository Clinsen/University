% Пункт 1: Інформація про функцію purelin
name = purelin('name');         % Повна назва функції
inrange = purelin('active');    % Діапазон входу
outrange = purelin('output');   % Діапазон виходу

disp('Інформація про функцію purelin:');
disp(['Повна назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -5:0.1:5;
a = purelin(n);
da = dpurelin(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації purelin');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dpurelin');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-0.7; 0.1; 0.8];
A = purelin(N);          % Вектор виходу функції активації
dA_dN = dpurelin(N);     % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');