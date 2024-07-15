create table "TemizlikSirketi" (
    "TemSirNo" SERIAL Not NULL,
    "TemSirAdi" varchar(60),
    constraint "TemSirPK" primary key ("TemSirNo")
);

create table "YemekSirketi" (
    "YemekSirNo" SERIAL Not NULL,
    "YemekSirAdi" varchar(60),
    constraint "YemekSirPK" primary key ("YemekSirNo")
);

create table "il" (
    "ilKodu" SERIAL Not NULL,
    "ilAdi" varchar(20),
    constraint "ilPK" primary key ("ilKodu")
);

create table "Otel" (
    "OtelNo" SERIAL not null,
    "OtelAdi" varchar(60),
    "ilKodu" int,
    "TemSirNo" int,
    "YemekSirNo" int,
    constraint "OtelPK" primary key ("OtelNo"),
    CONSTRAINT "OtelFK1" foreign key ("TemSirNo") references "TemizlikSirketi" ("TemSirNo"),
    CONSTRAINT "OtelFK2" foreign key ("YemekSirNo") references "YemekSirketi" ("YemekSirNo"),
    constraint "OtelFK3" foreign key ("ilKodu") REFERENCES "il" ("ilKodu")
);

create table "Blok" (
    "BlokNo" SERIAL Not null,
    "OtelNo" int,
    CONSTRAINT "BlokPK" primary key ("BlokNo"),
    CONSTRAINT "BlokFK" foreign key ("OtelNo") references "Otel" ("OtelNo")
);

CREATE  table "Kisi" (
    "KisiNo" SERIAL not NULL,
    "OtelNo" INT,
    "KisiAdi" VARCHAR(50),
    "KisiSoyadi" varchar(50),
    "KisiTuru" CHARACTER(1) not null,
	CONSTRAINT "KisiPK" PRIMARY KEY ("KisiNo"),
	CONSTRAINT "KisiFK" foreign key ("OtelNo") REFERENCES "Otel" ("OtelNo")
);

create table "Musteri" (
    "KisiNo" INT,
    constraint "MusteriPK" primary key ("KisiNo"),
    constraint "MsuteriFK" foreign key ("KisiNo") references "Kisi"("KisiNo") 
        on delete cascade on update CASCADE
);

create table "Yonetici" (
    "KisiNo" INT,
    "MesaiSuresi" int,
    constraint "YoneticiPK" primary key ("KisiNo"),
    constraint "YoneticiFK" foreign key ("KisiNo") references "Kisi"("KisiNo") 
        on delete cascade on update CASCADE
);

create table "Personel" (
    "KisiNo" INT,
    "BlokNo" int,
    constraint "PersonelPK" primary key ("KisiNo"),
    CONSTRAINT "PersonelFK1" FOREIGN key ("BlokNo") references "Blok" ("BlokNo"),
    constraint "PersonelFK2" foreign key ("KisiNo") references "Kisi"("KisiNo") 
        on delete cascade on update CASCADE
);

create table "OdaTipi" (
    "OdaTipiNo" SERIAL not null,
    "TurAdi" varchar(20),
    "KisiSayisi" INT,
    CONSTRAINT "OdaTipiPK" primary key ("OdaTipiNo")
);

create table "Oda" (
    "OdaNo" int not NULL,
    "BlokNo" INT,
    "OdaTipiNo" INT,
    "BirimUcret" int,
    "Durum" varchar(4),
    CONSTRAINT "OdaPK" primary key ("OdaNo"),
    CONSTRAINT "OdaFK1" FOREIGN key ("BlokNo") references "Blok" ("BlokNo"),
    constraint "OdaFK2" foreign key ("OdaTipiNo") references "OdaTipi" ("OdaTipiNo")
);

create table "Rezervasyon" (
    "RezNo" SERIAL not NULL,
    "OdaNo" INT,
    "MusteriNo" INT,
    "GirisTarihi" DATE DEFAULT '2023-01-01',
    "CikisTarihi" DATE DEFAULT '2023-01-01',
    CONSTRAINT "RezPK" primary key ("RezNo"),
    CONSTRAINT "RezFK1" FOREIGN key ("OdaNo") references "Oda" ("OdaNo"),
    constraint "RezFK2" foreign key ("MusteriNo") references "Musteri" ("KisiNo")
);

create Table "Hizmet" (
    "HizmetNo" SERIAL not null,
    "HizmetAdi" varchar(50),
    CONSTRAINT "HizmetPK" primary key ("HizmetNo")
);

create table "MusteriHizmet" (
    "MHNo" SERIAL Not NULL,
    "KisiNo" int,
    "HizmetNo" INT,
    constraint "MHPK" primary key ("MHNo"),
    constraint "MHFK1" foreign Key ("KisiNo") references "Musteri" ("KisiNo"),
    constraint "MHFK2" foreign key ("HizmetNo") references "Hizmet" ("HizmetNo")
);

create table "iletisim" (
    "iletisimNo" SERIAL not null,
    "OtelNo" INT,
    "Telefon" bigINT,
    "ePosta" VARCHAR(50),
    constraint "iletisimPK" primary key ("iletisimNo"),
    CONSTRAINT "iletisimFK" foreign key ("OtelNo") references "Otel" ("OtelNo")
);


CREATE OR REPLACE FUNCTION "musteri_ekle"(k_adi VARCHAR(50), k_soyadi VARCHAR(50),otel_no int)
RETURNS VOID AS 
$$
DECLARE KisiNo int;
BEGIN
    INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
    VALUES (k_adi,k_soyadi,otel_No, 'M' )RETURNING "KisiNo" INTO KisiNo;

    INSERT INTO "Musteri"("KisiNo")
    VALUES (KisiNo);
END;
$$ 
LANGUAGE 'plpgsql';


CREATE  or REPLACE FUNCTION "musteri_listele"()
returns Table ("KisiAdi" VARCHAR(50), "KisiSoyadi" VARCHAR(50),"OtelNo" int, "OtelAdi" VARCHAR(60)) as 
$$
BEGIN
    RETURN QUERY
    SELECT "Kisi"."KisiAdi", "Kisi"."KisiSoyadi", "Kisi"."OtelNo" , "Otel"."OtelAdi"
    FROM "Musteri"
    INNER JOIN "Kisi" ON "Musteri"."KisiNo" = "Kisi"."KisiNo"
    INNER JOIN "Otel" ON "Kisi"."OtelNo" = "Otel"."OtelNo";
END;
$$ 
LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION "rezervasyon_tarihi_guncelle"(rez_no INT,giris_tarih DATE,cikis_tarih DATE)
RETURNS VOID AS 
$$
BEGIN
    UPDATE "Rezervasyon"
    SET "GirisTarihi" = giris_tarih,
        "CikisTarihi" = cikis_tarih
    WHERE "RezNo" = rez_no;
END;
$$
LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION "rezervasyon_oda_guncelle"(rez_no INT,oda_no int)
RETURNS VOID AS 
$$
BEGIN
    UPDATE "Rezervasyon"
    SET "OdaNo" = oda_no
    WHERE "RezNo" = rez_no;
END;
$$
LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION "odaNo_ile_rez_getir"(oda_no INT)
RETURNS TABLE ("RezNo" INT, "OdaNo" INT, "MusteriNo" INT, "GirisTarihi" DATE, "CikisTarihi" DATE) AS
$$
BEGIN
    RETURN QUERY
    SELECT "Rezervasyon"."RezNo", "Rezervasyon"."OdaNo", "Rezervasyon"."MusteriNo", "Rezervasyon"."GirisTarihi", "Rezervasyon"."CikisTarihi"
    FROM "Rezervasyon"
    WHERE "Rezervasyon"."OdaNo" = oda_no;
END;
$$ LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION "rezervasyon_listele"()
RETURNS TABLE ("RezNo" INT, "OdaNo" INT, "MusteriNo" INT, "GirisTarihi" DATE, "CikisTarihi" DATE) AS 
$$
BEGIN
    RETURN QUERY
    SELECT * FROM "Rezervasyon";
END;
$$ 
LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION "rezervasyon_sil"(rez_no INT)
RETURNS VOID
AS 
$$
BEGIN
    DELETE FROM "Rezervasyon"
    WHERE "RezNo" = rez_no;
END;
$$ 
LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION "kontrol_rezervasyon"()
RETURNS TRIGGER 
AS 
$$
DECLARE
    var_count INTEGER;
BEGIN
    SELECT COUNT(*) INTO var_count
    FROM "Rezervasyon"
    WHERE "OdaNo" = OLD."OdaNo";

    IF var_count > 0 THEN
        RAISE EXCEPTION 'Bu oda rezerve edilmiş, oda silinemez.';
    END IF;

    RETURN OLD;
END;
$$
LANGUAGE 'plpgsql';


CREATE TRIGGER trig_kontrol_rezervasyon
BEFORE DELETE ON "Oda"
FOR EACH ROW
EXECUTE FUNCTION kontrol_rezervasyon();

DELETE FROM "Oda" WHERE "OdaNo" = 301; 


CREATE OR REPLACE FUNCTION "OtelAdiDuzenle"()
RETURNS TRIGGER 
AS
$$
BEGIN
    NEW."OtelAdi" = UPPER(NEW."OtelAdi"); -- büyük harfe dönüştürdükten sonra ekle
    NEW."OtelAdi" = TRIM(NEW."OtelAdi"); -- Önceki ve sonraki boşlukları temizle
    RETURN NEW;
END;
$$
LANGUAGE 'plpgsql';

CREATE TRIGGER "isimDuzenle"
BEFORE INSERT OR UPDATE ON "Otel"
FOR EACH ROW
EXECUTE PROCEDURE "OtelAdiDuzenle"();

CREATE OR REPLACE FUNCTION "iletisimKontrol"()
RETURNS TRIGGER 
AS 
$$
BEGIN
    IF NEW."Telefon" < 1000000000 OR NEW."Telefon" > 9999999999 THEN
        RAISE EXCEPTION 'Geçersiz telefon numarası!';
    END IF;

    RETURN NEW;
END;
$$
LANGUAGE 'plpgsql';

CREATE TRIGGER "KontrolIletisim"
BEFORE INSERT OR UPDATE On "iletisim"
FOR EACH ROW
EXECUTE PROCEDURE "iletisimKontrol"();

CREATE OR REPLACE FUNCTION "KontrolBlokOtel"()
RETURNS TRIGGER AS 
$$
BEGIN
     IF NOT EXISTS (
        SELECT *
        FROM "Blok"
        WHERE "BlokNo" = NEW."BlokNo"
    ) THEN
        RAISE EXCEPTION 'Belirtilen blok numarası bulunamadı!';
    END IF;

    RETURN NEW;
END;
$$ 
LANGUAGE 'plpgsql';

CREATE TRIGGER "BlokOtelKontrolTrigger"
BEFORE INSERT OR UPDATE ON "Personel"
FOR EACH ROW
EXECUTE FUNCTION "KontrolBlokOtel"();

insert into "il" ("ilAdi")
values ('Sakarya');
insert into "il" ("ilAdi")
values ('Istanbul');
insert into "il" ("ilAdi")
values ('Ankara');

insert into "TemizlikSirketi" ("TemSirAdi")
values ('Kristal Temizlik');

insert into "YemekSirketi" ("YemekSirAdi")
values ('Lezzet Haritasi');

insert into "YemekSirketi" ("YemekSirAdi")
values ('Mutfak Sanatlari');

INSERT INTO "Otel" ("OtelAdi","ilKodu","TemSirNo","YemekSirNo")
values ('  Miriana ','1', '1', '1');

INSERT INTO "Otel" ("OtelAdi","ilKodu","TemSirNo","YemekSirNo")
values ('      diamond house ', '2' , '1', '2');

insert into "Otel" ("OtelAdi","ilKodu","YemekSirNo")
values ('Tulip Garden','3','2');


insert into "OdaTipi"("TurAdi","KisiSayisi")
values ('Standart','2');

insert into "OdaTipi"("TurAdi","KisiSayisi")
values ('Standart','3');

insert into "OdaTipi"("TurAdi","KisiSayisi")
values ('Suit','1');

insert into "OdaTipi"("TurAdi","KisiSayisi")
values ('Suit','2');

insert into "Blok" ("OtelNo")
values ('1');

insert into "Blok" ("OtelNo")
values ('1');

insert into "Blok" ("OtelNo")
values ('2');

insert into "Blok" ("OtelNo")
values ('2');

insert into "Blok" ("OtelNo")
values ('2');

insert into "Blok" ("OtelNo")
values ('3');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('101','1','1');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('102','1','2');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('301','2','3');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('302','2','4');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('401','3','3');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('402','3','4');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('119','5','2');

insert into "Oda" ("OdaNo","BlokNo","OdaTipiNo")
values ('118','6','1');

select * from "Kisi";
select * From "Musteri";
select * From "Rezervasyon";
select * from "OdaTipi";
SELECT * from "Otel";
SELECT * from "Blok";
select * from "Oda";
select * from "iletisim";

SELECT * from "musteri_ekle"('Reyhan','Genc',1);
SELECT * from "musteri_ekle"('Ebrar','Genc',1);
SELECT * from "musteri_ekle"('Mete','Gazoz',2);
SELECT * from "musteri_ekle"('Mert','Güneş',2);
SELECT * from "musteri_ekle"('Melis','Yılmaz',2);
SELECT * from "musteri_ekle"('Pınar','Şeker',3);
SELECT * from "musteri_ekle"('Aysun','Kara',3);
select * from "musteri_listele"();

insert into "Rezervasyon" ("OdaNo","MusteriNo","GirisTarihi","CikisTarihi")
values ('302','1','01-02-2023','07-02-2023');

insert into "Rezervasyon" ("OdaNo","MusteriNo","GirisTarihi","CikisTarihi")
values ('102','2','01-02-2023','07-02-2023');

insert into "Rezervasyon" ("OdaNo","MusteriNo","GirisTarihi","CikisTarihi")
values ('119','14','02-02-2023','07-02-2023');

insert into "Rezervasyon" ("OdaNo","MusteriNo","GirisTarihi","CikisTarihi")
values ('402','13','01-02-2023','02-07-2023');

select * from "Kisi";
select * from "musteri_listele"();
select * from "rezervasyon_listele"();
select * from "odaNo_ile_rez_getir"(102);

insert into "iletisim" ("OtelNo","Telefon","ePosta")
values ('2','5554443322','diamondh@gmail.com');

insert into "iletisim" ("OtelNo","Telefon")
values ('2','9997776655');

insert into "iletisim" ("OtelNo","Telefon","ePosta")
values ('1','9097076655','miriana@gmail.com');

insert into "iletisim" ("OtelNo","Telefon")
values ('3','7765543212');

SELECT * FROM "iletisim"
    INNER JOIN "Otel" ON "iletisim"."OtelNo" = "Otel"."OtelNo";

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Mert','Şen','1','Y' );

INSERT INTO "Yonetici"("KisiNo","MesaiSuresi")
VALUES (3,8);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Pelin','Kara','1','Y' );

INSERT INTO "Yonetici"("KisiNo","MesaiSuresi")
VALUES (4,8);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Aslı','Irmak','2','Y' );

INSERT INTO "Yonetici"("KisiNo","MesaiSuresi")
VALUES (5,7);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Meltem','Demir','2','Y' );

INSERT INTO "Yonetici"("KisiNo","MesaiSuresi")
VALUES (6,8);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Murat','Keskin','3','Y' );

INSERT INTO "Yonetici"("KisiNo","MesaiSuresi")
VALUES (7,8);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Duru','Demir','2','P' );

INSERT INTO "Personel"("KisiNo","BlokNo")
VALUES (8,2);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Deniz','Cam','2','P' );

INSERT INTO "Personel"("KisiNo","BlokNo")
VALUES (9,1);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Ahmet','Kara','2','P' );

INSERT INTO "Personel"("KisiNo","BlokNo")
VALUES (10,1);

INSERT INTO "Kisi"("KisiAdi","KisiSoyadi","OtelNo","KisiTuru")
VALUES ('Ayşe','Yılmaz','3','P' );

INSERT INTO "Personel"("KisiNo","BlokNo")
VALUES (11,1);

select * from "Kisi";

SELECT * from "rezervasyon_oda_guncelle"(11,101);

select * from "Otel";

SELECT * from "musteri_ekle"('ali','Genc',1);

INSERT INTO "Otel" ("OtelAdi","ilKodu","TemSirNo","YemekSirNo")
values ('      diamond ', '2' , '1', '2');