from fastapi import FastAPI
from fastapi.responses import RedirectResponse
import core.db as db
from routers import car
import uvicorn


app = FastAPI()

app.include_router(car.router)


# redirect to docs
@app.get("/", include_in_schema=False)
def root():
    return RedirectResponse(url="/docs")


if __name__ == "__main__":
    db.create_db_and_tables()
    uvicorn.run("main:app", host="0.0.0.0", port=8000, reload=True)
