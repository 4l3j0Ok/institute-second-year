import os
from pathlib import Path


# Get the base directory (api folder)
BASE_DIR = Path(__file__).resolve().parent.parent


class AppConfig:
    HOST = os.getenv("APP_HOST", "localhost")
    PORT = int(os.getenv("APP_PORT", 8000))
    DEBUG = os.getenv("APP_DEBUG", "true").lower() in ("true", "1", "t")
    TITLE = os.getenv("APP_TITLE", "Concesionaria API")
    DESCRIPTION = os.getenv(
        "APP_DESCRIPTION", "API para gestionar vehículos en una concesionaria"
    )
    VERSION = os.getenv("APP_VERSION", "1.0.0")
    STATIC_DIR = os.getenv("STATIC_DIR", str(BASE_DIR / "public"))
    STATIC_URL = os.getenv("STATIC_URL", "/public")
