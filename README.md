# Weather Forecast Application

This application connects to public weather and geocoding REST APIs to provide a 7-day forecast based on a specified postal address. It uses the US Census Geocoding service to convert postal addresses into latitude and longitude and fetches weather data from the US National Weather Service API.

## Prerequisites

- .NET Core SDK
- Node.js and npm
- Visual Studio (preferably the latest version)

## How to Run

### Backend Setup

1. **Open the Backend Project**:
    - Open Visual Studio.
    - Navigate to the location where you cloned/downloaded the repository.
    - Open the `Weather.Forecast` solution file.
   
2. **Run the Backend**:
    - In Visual Studio, make sure `Weather.Forecast.API` is set as the startup project.
    - Click on the 'Run' button or press `F5` to start the backend server.

### Frontend Setup

1. **Navigate to the Frontend Directory**:
    ```bash
    cd path/to/repository/frontend
    ```

2. **Install Dependencies**:
    ```bash
    npm install
    ```

3. **Start the Frontend**:
    ```bash
    npm start
    ```

Once started, the frontend will allow you to find the weather forecast for specified postal addresses. It's a straightforward page: simply fill in the text field with an address and hit 'Search'.

**Some example addresses to try:**
- 1002 N 7th Ave, Phoenix, AZ 85007, USA
- 86 Brattle Street Cambridge, MA 02138
- 4600 Silver Hill Rd, Washington, DC 20233

## Configuration

🔔 **Quick Note for Setup**:
For ease of setup and because it's intended for showcase purposes, the necessary environment variables for the frontend and backend configuration are committed to the repository. This means you shouldn't need to modify these configurations to get started.

- Frontend configurations are found in the `.env` file.
- Backend configurations are located in `appsettings.json`.

No initial configuration changes are required to start!
