import React from 'react';

// Page containing information about Joel Hilton's podcast Baconsale

function PodcastInfo(props: any) {
  return (
    <>
      <div>
        <div className="text-center">
          <h1 className="display-4">My Podcasts</h1>
          <h3>I am part of an awesome podcast called Baconsale!</h3>
          <p>
            Check out the Baconsale website{' '}
            <a href="https://baconsale.com/">here!!</a>
          </p>
        </div>
      </div>
    </>
  );
}

export default PodcastInfo;
