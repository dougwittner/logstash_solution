drop table if exists public.cars;
-- auto-generated definition
create table cars
(
    id          serial
        constraint cars_pk
            primary key,
    make        varchar(255),
    description varchar(255),
    model       varchar(255),
    year        integer,
    created_datetime timestamp default now(),
    modified_datetime timestamp default now()
);
insert into cars (make, description, model, year) values ('Ford', 'Fusion', 'SE', 2017);

alter table cars
    owner to dwittn32;