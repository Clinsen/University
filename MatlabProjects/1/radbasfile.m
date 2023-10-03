% Функція dradbas для обчислення похідної функції активації radbas
function d = dradbas(n)
    d = (-2) * n .* radbas(n);
end

% Пункт 1: Інформація про функцію radbas
name = 'radbas';                % Назва функції активації
inrange = [0, inf];             % Діапазон входу
outrange = [0, 1];              % Діапазон виходу

disp('Інформація про функцію radbas:');
disp(['Назва: ' name]);
disp(['Діапазон входу: ' num2str(inrange)]);
disp(['Діапазон виходу: ' num2str(outrange)]);

% Пункт 2: Побудувати графіки функцій
n = 0:0.01:5;
a = radbas(n);
da = dradbas(n);

figure;
plot(n, a, 'r')   % Графік функції активації - червоний
title('Графік функції активації radbas');
xlabel('n');
ylabel('Виход');
grid on;

figure;
plot(n, da, 'c')  % Графік похідної - блакитний
title('Графік похідної dradbas');
xlabel('n');
ylabel('Похідна');
grid on;

% Пункт 3: Обчислити вектори виходу
N = [0.5; 1.2; 3.0];
A = radbas(N);          % Вектор виходу функції активації
dA_dN = dradbas(N);     % Вектор виходу похідної

disp('Вектор виходу A:');
disp(A');

disp('Вектор виходу похідної dA_dN:');
disp(dA_dN');
