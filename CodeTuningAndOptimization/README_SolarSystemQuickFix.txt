lines 96 - 99
before:
        private void EarthRotation()
        {
			for (decimal step = 0; step <= 360; step+=0.00005m)
			{
				EarthRotationAngle = ((double)step) * Days / EarthRotationPeriod;
			}
            Update("EarthRotationAngle");
        }

after:
        private void EarthRotation()
        {
	    EarthRotationAngle = 360 * Days / EarthRotationPeriod;
            Update("EarthRotationAngle");
        }