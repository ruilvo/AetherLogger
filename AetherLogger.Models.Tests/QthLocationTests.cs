// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

using AetherLogger.Models.Location;

namespace AetherLogger.Models.Tests
{
    public class QthLocationTests
    {
        [Test]
        public void GetQthLocationFromCoordinates()
        {
            QthLocation qthLocation = new(new(-8.609848, 41.148591));
            string maidenheadGrid = qthLocation.ToGridSquare();
            string correctMaidenheadGrid = "IN51qd".ToUpper();
            Assert.That(maidenheadGrid, Is.EqualTo(correctMaidenheadGrid));
        }
    }
}