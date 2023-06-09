CREATE TABLE Customers (
    customer_id NUMBER,
    username VARCHAR2(50),
    password VARCHAR2(50),
    first_name VARCHAR2(50),
    last_name VARCHAR2(50),
    email VARCHAR2(50) UNIQUE,
    phone VARCHAR2(20),
    address VARCHAR2(100),
    city VARCHAR2(50),
    county VARCHAR2(50),
    eircode VARCHAR2(10),
    account_status VARCHAR2(20),
    CONSTRAINT pk_customer PRIMARY KEY (customer_id)
);

CREATE TABLE Administrators (
    admin_id NUMBER,
    username VARCHAR2(50),
    first_name VARCHAR2(50),
    last_name VARCHAR2(50),
    email VARCHAR2(50) UNIQUE,
    password VARCHAR2(50),
    account_status VARCHAR2(20),
    is_root char(1),
    CONSTRAINT pk_administrator PRIMARY KEY (admin_id)
);

CREATE TABLE Orders (
    order_id NUMBER,
    customer_id NUMBER,
    order_date DATE,
    order_status VARCHAR2(20),
    total_amount NUMBER(10,2),
    CONSTRAINT pk_order PRIMARY KEY (order_id),
    CONSTRAINT fk_customer_order FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

CREATE TABLE Products (
    product_id NUMBER,
    product_name VARCHAR2(50),
    product_description VARCHAR(50),
    price NUMBER(10,2),
    quantity_available NUMBER,
    is_available char(1),
    CONSTRAINT pk_product PRIMARY KEY (product_id)
);

CREATE TABLE Order_items (
    order_item_id NUMBER,
    order_id NUMBER,
    product_id NUMBER,
    quantity_ordered NUMBER,
    item_price NUMBER(10,2),
    CONSTRAINT pk_order_item PRIMARY KEY (order_item_id),
    CONSTRAINT fk_order_order_item FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    CONSTRAINT fk_product_order_item FOREIGN KEY (product_id) REFERENCES Products(product_id)
);
