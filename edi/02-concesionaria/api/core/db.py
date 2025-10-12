from sqlmodel import create_engine, SQLModel, Session

sqlite_file_name = "database.db"
sqlite_url = f"sqlite:///{sqlite_file_name}"

# Permite conexiones desde múltiples hilos (útil en aplicaciones web).
connect_args = {"check_same_thread": False}
engine = create_engine(sqlite_url, connect_args=connect_args)


def get_session():
    """
    Dependencia de FastAPI para obtener una sesión de base de datos.
    Esta función se usa cuando se necesita interactuar con la base de datos
    en las rutas de la API, principalmente en operaciones `CRUD` para asegurar
    que cada solicitud tenga su propia sesión de base de datos.
    """
    with Session(engine) as session:
        yield session


def create_db_and_tables():
    # Drop existing tables to ensure the database schema matches the current models.
    # WARNING: This will erase existing data — use only in development or when you
    # intentionally want to reset the database.
    SQLModel.metadata.drop_all(engine)
    SQLModel.metadata.create_all(engine)
