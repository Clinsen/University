% Пункт 1: Інформація про функцію poslin
name = 'poslin';                % Назва функції активації
inrange = [0, inf];             % Діапазон входу
outrange = [0, inf];            % Діапазон виходу

disp('Інформація про функцію poslin:');
disp(['Назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = -5:0.1:5;
a = poslin(n);
da = dposlin(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації poslin');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dposlin');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [-0.7; 0.1; 0.8];
A = poslin(N);          % Вектор виходу функції активації
dA_dN = dposlin(N);     % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');
