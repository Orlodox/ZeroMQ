# ZeroMQ
ZeroMQ - это библиотека обмена сообщениями (Messaging Queue, MQ), которая без особых усилий позволяет создавать сложные коммуникационные решения. Сначала эта программная компонента разрабатывалась как интерфейс для обмена сообщениями (messaging middleware), затем - как легкий коммуникационный протокол, основанный на TCP/IP, а в настоящее время ZeroMQ позиционируется как новая компонента в стеке сетевых протоколов.

- Производительность.
 ZeroMQ действительно работает существенно быстрее, чем большинство реализаций AMQP, и это достигается:
  - отсутствием поддержки AMQP и соответствующих этому протоколу издержек
  - использованием эффективных транспортов, например широковещательного протокола с гарантированной доставкой или оригинальной разработки ZeroMQ - набора вызовов для многопотоковой рассылки сообщений нескольким адресатам
  - использованием агрегированной отправки нескольких сообщений в одном TCP-пакете, это тоже разработка ZeroMQ, что позволяет не только минимизировать издержки сетевого протокола, но и уменьшить количество системных вызовов.


- Простота использования. 
  - С помощью API ZeroMQ передача сообщения действительно проще, чем при использовании сокетов, где вам нужно, например, следить за длиной сокетного буфера, а в ZeroMQ - просто инициировать отправку сообщения, а дробление (или агрегация) и отправка делается API в отдельном потоке, асинхронно с выполнением пользовательского кода. Асинхронная природа методов ZeroMQ особенно удобна для реализации механизмов событийной обработки. Немаловажным удобством в ZeroMQ является отказ от типизации сообщений передаваемых интерфейсом - сообщения никак не интерпретируются интерфейсом и являются BLOB (областью памяти). Таким образом, через ZeroMQ можно передавать что угодно, например сообщения JSON или двоичные форматированные данные типа BSON, Protocol Buffers или Thrift, не чувствуя при этом никаких неудобств.


- Масштабируемость. 
  - Являясь низкоуровневым интерфейсом, ZeroMQ, тем не менее, предоставляет множество опций, например сокет ZeroMQ может быть подключенным к нескольким адресатам и равномерно распределять нагрузку по сети. Другая возможность - это входное мультиплексирование, когда один сокет может получать сообщения от множества отправителей. В ZeroMQ реализована децентрализованная схема обмена сообщениями. Это, в комбинации с высокой производительностью, дает возможность построения распределенных систем любой сложности.
  
  
  # Как развернуть проект
  - Загрузить архив с проектом
  ![](https://github.com/Orlodox/ZeroMQ/blob/master/IMG/Screenshot_2.png)
  
  - Распаковать архив
  
  - Запустить файл ZMQ.sln (требуется Visual Studio)
  ![](https://github.com/Orlodox/ZeroMQ/blob/master/IMG/Screenshot_3.png)
  
  - В запущенном окне нажать"Пуск"
  ![](https://github.com/Orlodox/ZeroMQ/blob/master/IMG/Screenshot_4.png)
