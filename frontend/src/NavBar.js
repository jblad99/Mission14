// This file creates the navbar that is used to navigate between pages
// The 'react-router'dom' is used for that navigation and includes links to all the pages and a site title
import { Link, useMatch, useResolvedPath } from 'react-router-dom';

export default function Navbar() {
  return (
    <nav className="nav">
      <Link to="/" className="site-title">
        The Joel Hilton Film Collection
      </Link>
      <ul>
        <CustomLink to="/">Home</CustomLink>
        <CustomLink to="/podcasts">Podcasts</CustomLink>
        <CustomLink to="/movies">Movies</CustomLink>
      </ul>
    </nav>
  );
}

function CustomLink({ to, children, ...props }) {
  const resolvedPath = useResolvedPath(to);
  const isActive = useMatch({ path: resolvedPath.pathname, end: true });

  return (
    <li className={isActive ? 'active' : ''}>
      <Link to={to} {...props}>
        {children}
      </Link>
    </li>
  );
}
