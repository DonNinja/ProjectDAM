CREATE DATABASE 2605993489_ProjectDAM;

USE 2605993489_ProjectDAM;

DROP TABLE IF EXISTS Account;

CREATE TABLE Account (
	ID INT PRIMARY KEY auto_increment,
	u_name VARCHAR (35),
    p_word VARCHAR (35),
    email VARCHAR (35),
    accd DATE,
    login_count INT
);

INSERT INTO Account (u_name, p_word, email, accd) VALUES ("prufa", "prufushiss", "prufu@email.is", "2005-12-24")