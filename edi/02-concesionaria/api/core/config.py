import os


BASE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))


class AppConfig:
    HOST = os.getenv("APP_HOST", "localhost")
    PORT = int(os.getenv("APP_PORT", 8000))
    DEBUG = os.getenv("APP_DEBUG", "true").lower() in ("true", "1", "t")
    TITLE = os.getenv("APP_TITLE", "Concesionaria API")
    DESCRIPTION = os.getenv(
        "APP_DESCRIPTION", "API para gestionar vehículos en una concesionaria"
    )
    VERSION = os.getenv("APP_VERSION", "1.0.0")
    STATIC_DIR = os.getenv("STATIC_DIR", f"{BASE_DIR}/public")
    STATIC_URL = os.getenv("STATIC_URL", "/public")


class LoggerConfig:
    LOG_NAME = os.getenv("LOG_NAME", "app")
    LOG_LEVEL = os.getenv("LOG_LEVEL", "INFO").upper()
    LIBRARY_LOGS_PREFIXES = ("uvicorn", "fastapi", "sqlalchemy", "sqlmodel")
    LOG_COLORS = {
        "DEBUG": "blue",
        "INFO": "green",
        "WARNING": "yellow",
        "ERROR": "red",
        "CRITICAL": "bold_red",
    }
