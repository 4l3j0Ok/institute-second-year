const domain = import.meta.env.CARS_API_DOMAIN
const apiUrl = `${domain}/cars`


export const getCar = async (car_code?: string) => {
    const url = car_code ? `${apiUrl}?car_code=${car_code}` : apiUrl

    try {
        const res = await fetch(url)
        if (!res.ok) {
            throw new Error(`HTTP error! status: ${res.status}`)
        }
        const data = await res.json()
        return data
    } catch (error) {
        console.error('Error fetching car:', error)
        return { items: [] }
    }
}