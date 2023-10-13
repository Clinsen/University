% Пункт 1: Інформація про функцію softmax
Name = 'softmax';               % Назва функції
Inrange = [-inf, inf];           % Діапазон входу
Outrange = [0, 1];               % Діапазон виходу

disp('Інформація про функцію softmax:');
disp(['Назва: ' Name]);
disp(['Діапазон входу: ' num2str(Inrange)]);
disp(['Діапазон виходу: ' num2str(Outrange)]);

% Пункт 2: Побудувати стовпцеві діаграми для вектора входу та виходу
N = [2; 1; 3; 4];  % Приклад вектора входу
A = softmax(N);     % Обчислення вектора виходу за допомогою softmax

subplot(2,1,1);     % 2x1 підвікно; вивід у 1-е підвікно
bar(N);             % стовпчаста діаграма вектора входу
ylabel('n');         % мітка осі ординат

subplot(2,1,2);     % друге підвікно
bar(A);             % стовпчаста діаграма вектора виходу
ylabel('a');         % мітка осі ординат