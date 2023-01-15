import { Counter } from "./components/Counter";
import Details from "./components/Details";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import Insert from "./components/Insert";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
  {
    path: '/details',
    element: <Details />
  },
  {
    path: '/insert',
    element: <Insert />
  }
];

export default AppRoutes;
